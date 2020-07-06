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
    public partial class Form1 : Form
    {

        Database db;
        public static string curr_device_id;
        public Form1()
        {
            InitializeComponent();

            curr_device_id = "";
            db = new Database();
            lv_devices.View = View.Details;
            lv_devices.GridLines = true;
            lv_devices.FullRowSelect = true;
            lv_devices.Columns.Add("ID", 300);
            lb_log.HorizontalScrollbar = true;
            refreshDevices();

        }

        public void refreshDevices()
        {
            lv_devices.Items.Clear();
            List<string> devices_id = db.getDevicesID();

            foreach(string id in devices_id)
            {
                lv_devices.Items.Add(new ListViewItem(id));
            }
        }

        public void showLog(string log)
        {
            lb_log.Items.Add(log);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            curr_device_id = "";
            DeviceForm deviceForm = new DeviceForm();
            deviceForm.Show();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if(lv_devices.SelectedItems.Count > 0)
            {
                curr_device_id = lv_devices.SelectedItems[0].SubItems[0].Text;
                DeviceForm deviceForm = new DeviceForm();
                deviceForm.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali uređaj!");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (lv_devices.SelectedItems.Count > 0)
            {
                string device_id = lv_devices.SelectedItems[0].SubItems[0].Text;
                db.deleteDevice(device_id);
                refreshDevices();
            }
            else
            {
                MessageBox.Show("Niste odabrali uređaj!");
            }
        }

        private void status_button_Click(object sender, EventArgs e)
        {
            if (lv_devices.SelectedItems.Count > 0)
            {
                Device tmp_device = new Device();
                tmp_device.id = lv_devices.SelectedItems[0].SubItems[0].Text;
                string json = JsonConvert.SerializeObject(tmp_device);

                string result = db.getDeviceStatusByID(json);
                showLog(result);

                Device device = JsonConvert.DeserializeObject<Device>(result);
                lb_device.Items.Clear();
                lb_device.Items.Add("ID: " + device.id);
                lb_device.Items.Add("Status: " + device.status);
                lb_device.Items.Add("Timestamp: " + device.timestamp + " ms");

                lb_sensors.Items.Clear();
                phase_1.Checked = false;
                phase_2.Checked = false;
                phase_3.Checked = false;
                phase_4.Checked = false;
                phase_5.Checked = false;
                phase_6.Checked = false;
                phase_7.Checked = false;
                phase_8.Checked = false;

                foreach(Sensor sensor in device.sensors)
                {
                    if(sensor.id == 3)
                    {
                        int temperature_f = Convert.ToInt32(sensor.value, 16);
                        double temperature_c = Math.Round((temperature_f - 32) / 1.8, 1);

                        lb_sensors.Items.Add(sensor.desc + ": " + sensor.value + " " + temperature_f + "F (" + temperature_c + "C)");
                    }
                    else if(sensor.id == 4)
                    {
                        lb_sensors.Items.Add(sensor.desc + ": " + sensor.value);
                        string phases_bin = Convert.ToString(Convert.ToInt64(sensor.value, 16), 2).PadLeft(8, '0');
                        for(int i = 0; i < 8; i++)
                        {
                            if(phases_bin[i] == '1'){
                                switch (i)
                                {
                                    case 0:
                                        phase_1.Checked = true;
                                        break;
                                    case 1:
                                        phase_2.Checked = true;
                                        break;
                                    case 2:
                                        phase_3.Checked = true;
                                        break;
                                    case 3:
                                        phase_4.Checked = true;
                                        break;
                                    case 4:
                                        phase_5.Checked = true;
                                        break;
                                    case 5:
                                        phase_6.Checked = true;
                                        break;
                                    case 6:
                                        phase_7.Checked = true;
                                        break;
                                    case 7:
                                        phase_8.Checked = true;
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        lb_sensors.Items.Add(sensor.desc + ": " + sensor.value);
                    }
                }

            }
            else
            {
                MessageBox.Show("Niste odabrali uređaj!");
            }
        }

        private void config_button_Click(object sender, EventArgs e)
        {
            if (lv_devices.SelectedItems.Count > 0)
            {
                Dictionary<string, string> json_object = new Dictionary<string, string>();
                json_object.Add("id", lv_devices.SelectedItems[0].SubItems[0].Text);

                string json = JsonConvert.SerializeObject(json_object);
                showLog(json);

                string response = db.getAction(json);
                showLog(response);
            }
            else
            {
                MessageBox.Show("Niste odabrali uređaj!");
            }
        }
    }
}
