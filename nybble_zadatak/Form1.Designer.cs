namespace nybble_zadatak
{
    partial class Form1
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
            this.dgv_devices = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.status_button = new System.Windows.Forms.Button();
            this.config_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_device = new System.Windows.Forms.ListBox();
            this.lb_sensors = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phase_1 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_log = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uređaji";
            // 
            // dgv_devices
            // 
            this.dgv_devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devices.Location = new System.Drawing.Point(12, 29);
            this.dgv_devices.Name = "dgv_devices";
            this.dgv_devices.Size = new System.Drawing.Size(655, 219);
            this.dgv_devices.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(700, 29);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(700, 58);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "Uredi";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(700, 87);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Ukloni";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // status_button
            // 
            this.status_button.Location = new System.Drawing.Point(700, 135);
            this.status_button.Name = "status_button";
            this.status_button.Size = new System.Drawing.Size(75, 23);
            this.status_button.TabIndex = 5;
            this.status_button.Text = "Status";
            this.status_button.UseVisualStyleBackColor = true;
            // 
            // config_button
            // 
            this.config_button.Location = new System.Drawing.Point(700, 165);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(75, 23);
            this.config_button.TabIndex = 6;
            this.config_button.Text = "Config";
            this.config_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status uređaja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senzori";
            // 
            // lb_device
            // 
            this.lb_device.FormattingEnabled = true;
            this.lb_device.Location = new System.Drawing.Point(12, 294);
            this.lb_device.Name = "lb_device";
            this.lb_device.Size = new System.Drawing.Size(381, 173);
            this.lb_device.TabIndex = 9;
            // 
            // lb_sensors
            // 
            this.lb_sensors.FormattingEnabled = true;
            this.lb_sensors.Location = new System.Drawing.Point(410, 294);
            this.lb_sensors.Name = "lb_sensors";
            this.lb_sensors.Size = new System.Drawing.Size(365, 173);
            this.lb_sensors.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Faze";
            // 
            // phase_1
            // 
            this.phase_1.AutoCheck = false;
            this.phase_1.AutoSize = true;
            this.phase_1.Location = new System.Drawing.Point(9, 508);
            this.phase_1.Name = "phase_1";
            this.phase_1.Size = new System.Drawing.Size(14, 13);
            this.phase_1.TabIndex = 12;
            this.phase_1.TabStop = true;
            this.phase_1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 508);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoCheck = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 508);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoCheck = false;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(69, 508);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoCheck = false;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(89, 508);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoCheck = false;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(109, 508);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoCheck = false;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(129, 508);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 18;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoCheck = false;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(149, 508);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 19;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Consol Log";
            // 
            // lb_log
            // 
            this.lb_log.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_log.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_log.FormattingEnabled = true;
            this.lb_log.Location = new System.Drawing.Point(12, 567);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(763, 173);
            this.lb_log.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.phase_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_sensors);
            this.Controls.Add(this.lb_device);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.status_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dgv_devices);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_devices;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button status_button;
        private System.Windows.Forms.Button config_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_device;
        private System.Windows.Forms.ListBox lb_sensors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton phase_1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_log;
    }
}

