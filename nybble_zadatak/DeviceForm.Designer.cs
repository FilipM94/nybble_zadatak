namespace nybble_zadatak
{
    partial class DeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_device_id = new System.Windows.Forms.TextBox();
            this.tb_sensor_humidity = new System.Windows.Forms.TextBox();
            this.tb_sensor_temperature = new System.Windows.Forms.TextBox();
            this.cb_device_status = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uređaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senzori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vlažnost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperatura";
            // 
            // tb_device_id
            // 
            this.tb_device_id.Location = new System.Drawing.Point(130, 68);
            this.tb_device_id.Name = "tb_device_id";
            this.tb_device_id.Size = new System.Drawing.Size(351, 20);
            this.tb_device_id.TabIndex = 6;
            // 
            // tb_sensor_humidity
            // 
            this.tb_sensor_humidity.Location = new System.Drawing.Point(130, 188);
            this.tb_sensor_humidity.Name = "tb_sensor_humidity";
            this.tb_sensor_humidity.Size = new System.Drawing.Size(351, 20);
            this.tb_sensor_humidity.TabIndex = 7;
            // 
            // tb_sensor_temperature
            // 
            this.tb_sensor_temperature.Location = new System.Drawing.Point(130, 228);
            this.tb_sensor_temperature.Name = "tb_sensor_temperature";
            this.tb_sensor_temperature.Size = new System.Drawing.Size(351, 20);
            this.tb_sensor_temperature.TabIndex = 8;
            // 
            // cb_device_status
            // 
            this.cb_device_status.FormattingEnabled = true;
            this.cb_device_status.Location = new System.Drawing.Point(130, 109);
            this.cb_device_status.Name = "cb_device_status";
            this.cb_device_status.Size = new System.Drawing.Size(351, 21);
            this.cb_device_status.TabIndex = 9;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(406, 275);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Spremi";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 332);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cb_device_status);
            this.Controls.Add(this.tb_sensor_temperature);
            this.Controls.Add(this.tb_sensor_humidity);
            this.Controls.Add(this.tb_device_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_device_id;
        private System.Windows.Forms.TextBox tb_sensor_humidity;
        private System.Windows.Forms.TextBox tb_sensor_temperature;
        private System.Windows.Forms.ComboBox cb_device_status;
        private System.Windows.Forms.Button save_button;
    }
}