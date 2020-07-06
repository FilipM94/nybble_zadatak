using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nybble_zadatak
{
    public partial class DeviceForm : Form
    {
        string curr_device_id;
        Database db;
        Device device;
        public DeviceForm()
        {
            InitializeComponent();

            db = new Database();
            List<string> status = new List<string>();
            status.Add("offline");
            status.Add("online");
            status.Add("error");
            cb_device_status.DataSource = status;

            curr_device_id = Form1.curr_device_id;
            if(curr_device_id != "")
            {
                Device d = new Device();
                d.id = curr_device_id;
                string json = JsonConvert.SerializeObject(d);

                string result = db.getDeviceStatusByID(json);
                device = JsonConvert.DeserializeObject<Device>(result);
                tb_device_id.Text = device.id;
                switch (device.status)
                {
                    case 0:
                        cb_device_status.SelectedItem = "offline";
                        break;
                    case 1:
                        cb_device_status.SelectedItem = "online";
                        break;
                    case 2:
                        cb_device_status.SelectedItem = "error";
                        break;
                }

                foreach(Sensor sensor in device.sensors)
                {
                    switch (sensor.id)
                    {
                        case 1:
                            tb_sensor_humidity.Text = sensor.value;
                            break;
                        case 3:
                            tb_sensor_temperature.Text = Convert.ToInt32(sensor.value, 16).ToString();
                            break;
                        case 5:
                            tb_phase_power.Text = Convert.ToInt32(sensor.value, 16).ToString();
                            break;
                    }
                }

                tb_device_id.Enabled = false;
            }
            else
            {
                device = new Device();
                tb_device_id.Enabled = true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            device.id = tb_device_id.Text;
            switch (cb_device_status.SelectedItem.ToString())
            {
                case "offline":
                    device.status = 0;
                    break;
                case "online":
                    device.status = 1;
                    break;
                case "error":
                    device.status = 2;
                    break;
            }

            if(curr_device_id == "")
            {
                device.sensors.Add(new Sensor(1, "humidity", tb_sensor_humidity.Text));
                device.sensors.Add(new Sensor(2, "phase_count", "0"));
                device.sensors.Add(new Sensor(3, "temperature", "0x" + Convert.ToInt32(tb_sensor_temperature.Text).ToString("X")));
                device.sensors.Add(new Sensor(4, "phase_count", "0x0"));
                device.sensors.Add(new Sensor(5, "phase_power_W", "0x" + Convert.ToInt32(tb_phase_power.Text).ToString("X")));

                db.insertDevice(device);
            }
            else
            {
                foreach(Sensor sensor in device.sensors)
                {
                    switch (sensor.id)
                    {
                        case 1:
                            sensor.value = tb_sensor_humidity.Text;
                            break;
                        case 2:
                            if(device.status == 0 || device.status == 2)
                            {
                                sensor.value = "0";
                            }
                            break;
                        case 3:
                            sensor.value = "0x" + Convert.ToInt32(tb_sensor_temperature.Text).ToString("X");
                            break;
                        case 4:
                            if (device.status == 0 || device.status == 2)
                            {
                                sensor.value = "0";
                            }
                            break;
                        case 5:
                            sensor.value = "0x" + Convert.ToInt32(tb_phase_power.Text).ToString("X");
                            break;
                    }
                }

                db.updateDevice(device);
            }

            this.Close();
        }
    }
}
