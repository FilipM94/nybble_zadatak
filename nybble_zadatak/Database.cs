using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nybble_zadatak
{
    class Database
    {
        private string connectionString = "server=localhost;database=nybble_zadatak;uid=root;pwd=0000";
        private MySqlConnection con;

        public Database()
        {
            con = new MySqlConnection(connectionString);
        }

        public List<string> getDevicesID()
        {
            List<string> devices = new List<string>();
            con.Open();

            string query = "SELECT * FROM devices";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                devices.Add(reader.GetString("id"));
            }

            con.Close();
            return devices;
        }

        public void insertDevice(Device device)
        {
            con.Open();
            string query = "INSERT INTO devices (id, status) VALUES(@id, @status);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", device.id);
            cmd.Parameters.AddWithValue("@status", device.status);
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO device_sensors (device_id, sensor_id, value) VALUES(@device_id, @sensor_id, @value);";
            foreach (Sensor sensor in device.sensors)
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@device_id", device.id);
                cmd.Parameters.AddWithValue("@sensor_id", sensor.id);
                cmd.Parameters.AddWithValue("@value", sensor.value);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void updateDevice(Device device)
        {
            con.Open();
            string query = "UPDATE devices SET status=@status WHERE id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", device.id);
            cmd.Parameters.AddWithValue("@status", device.status);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            query = "DELETE FROM device_sensors WHERE device_id=@device_id;";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@device_id", device.id);
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO device_sensors (device_id, sensor_id, value) VALUES(@device_id, @sensor_id, @value);";
            foreach (Sensor sensor in device.sensors)
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@device_id", device.id);
                cmd.Parameters.AddWithValue("@sensor_id", sensor.id);
                cmd.Parameters.AddWithValue("@value", sensor.value);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void deleteDevice(string device_id)
        {
            con.Open();
            string query = "DELETE FROM devices WHERE id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", device_id);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            query = "DELETE FROM device_sensors WHERE device_id=@device_id;";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@device_id", device_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getDeviceStatusByID(string json)
        {
            Device device = new Device();
            con.Open();
            Device json_device = JsonConvert.DeserializeObject<Device>(json);
            string query = "SELECT * FROM devices WHERE id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", json_device.id);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                device.id = reader.GetString("id");
                device.status = reader.GetInt32("status");
                device.timestamp = DateTime.Now.ToString("HHmmssffff");
            }
            reader.Close();
            con.Close();

            con.Open();
            query = "SELECT device_sensors.value, sensors.id, sensors.desc FROM device_sensors LEFT JOIN sensors ON device_sensors.sensor_id = sensors.id;";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@device_id", json_device.id);
            MySqlDataReader reader_sensor = cmd.ExecuteReader();

            while (reader_sensor.Read())
            {
                Sensor sensor = new Sensor();
                sensor.id = reader_sensor.GetInt32("id");
                sensor.desc = reader_sensor.GetString("desc");
                sensor.value = reader_sensor.GetString("value");

                device.sensors.Add(sensor);
            }
            reader_sensor.Close();
            con.Close();

            return JsonConvert.SerializeObject(device);
        }

        public string getAction(string json)
        {
            var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            Device tmp_device = new Device();
            tmp_device.id = response["id"];

            Device device = JsonConvert.DeserializeObject<Device>(getDeviceStatusByID(JsonConvert.SerializeObject(tmp_device)));
            double humidity = 0;
            int temperature_f = 0;
            foreach(Sensor sensor in device.sensors)
            {
                if(sensor.id == 1)
                {
                    humidity = double.Parse(sensor.value, CultureInfo.InvariantCulture);
                }
                else if(sensor.id == 3)
                {
                    temperature_f = Convert.ToInt32(sensor.value, 16);
                }
            }

            double temperature_c = Math.Round((temperature_f - 32) / 1.8, 1);
            string hex_phases = "0x0";
            int phases_count = 0;

            if(temperature_c < 80 && humidity < 87.50 && device.status == 1)
            {
                Random ran = new Random();
                int phases = ran.Next(255);
                hex_phases = "0x" + phases.ToString("X");

                string phases_bin = Convert.ToString(Convert.ToInt64(hex_phases, 16), 2).PadLeft(8, '0');
                for (int i = 0; i < 8; i++)
                {
                    if (phases_bin[i] == '1')
                    {
                        phases_count++;
                    }
                }
            }

            con.Open();
            string query = "UPDATE device_sensors SET value=@value WHERE device_id=@device_id AND sensor_id=@sensor_id;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@device_id", response["id"]);
            cmd.Parameters.AddWithValue("@sensor_id", 4);
            cmd.Parameters.AddWithValue("@value", hex_phases);
            cmd.ExecuteNonQuery();

            query = "UPDATE device_sensors SET value=@value WHERE device_id=@device_id AND sensor_id=@sensor_id;";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@device_id", response["id"]);
            cmd.Parameters.AddWithValue("@sensor_id", 2);
            cmd.Parameters.AddWithValue("@value", phases_count);
            cmd.ExecuteNonQuery();

            con.Close();

            response.Add("phase", hex_phases);
            return JsonConvert.SerializeObject(response);
        }
    }
}
