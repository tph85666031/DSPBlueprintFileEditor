namespace DSPBlueprintFileEditor
{
    partial class Form2
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
            this.button_ok = new System.Windows.Forms.Button();
            this.comboBox_belt = new System.Windows.Forms.ComboBox();
            this.label_belt_level = new System.Windows.Forms.Label();
            this.comboBox_sorter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_assemble = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_smelter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_vessel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_drone = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_warp_distance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_charge_power = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_station = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox_attr = new System.Windows.Forms.GroupBox();
            this.radioButton_extra = new System.Windows.Forms.RadioButton();
            this.radioButton_speed = new System.Windows.Forms.RadioButton();
            this.checkBox_attr = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_level = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vessel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_warp_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_charge_power)).BeginInit();
            this.groupBox_attr.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(191, 429);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // comboBox_belt
            // 
            this.comboBox_belt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_belt.Enabled = false;
            this.comboBox_belt.FormattingEnabled = true;
            this.comboBox_belt.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_belt.Location = new System.Drawing.Point(97, 35);
            this.comboBox_belt.Name = "comboBox_belt";
            this.comboBox_belt.Size = new System.Drawing.Size(168, 23);
            this.comboBox_belt.TabIndex = 1;
            this.comboBox_belt.SelectedIndexChanged += new System.EventHandler(this.comboBox_belt_SelectedIndexChanged);
            // 
            // label_belt_level
            // 
            this.label_belt_level.AutoSize = true;
            this.label_belt_level.Location = new System.Drawing.Point(12, 38);
            this.label_belt_level.Name = "label_belt_level";
            this.label_belt_level.Size = new System.Drawing.Size(47, 15);
            this.label_belt_level.TabIndex = 2;
            this.label_belt_level.Text = "Belt:";
            // 
            // comboBox_sorter
            // 
            this.comboBox_sorter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sorter.Enabled = false;
            this.comboBox_sorter.FormattingEnabled = true;
            this.comboBox_sorter.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_sorter.Location = new System.Drawing.Point(97, 68);
            this.comboBox_sorter.Name = "comboBox_sorter";
            this.comboBox_sorter.Size = new System.Drawing.Size(168, 23);
            this.comboBox_sorter.TabIndex = 1;
            this.comboBox_sorter.SelectedIndexChanged += new System.EventHandler(this.comboBox_sorter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorter:";
            // 
            // comboBox_assemble
            // 
            this.comboBox_assemble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_assemble.Enabled = false;
            this.comboBox_assemble.FormattingEnabled = true;
            this.comboBox_assemble.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_assemble.Location = new System.Drawing.Point(97, 101);
            this.comboBox_assemble.Name = "comboBox_assemble";
            this.comboBox_assemble.Size = new System.Drawing.Size(168, 23);
            this.comboBox_assemble.TabIndex = 1;
            this.comboBox_assemble.SelectedIndexChanged += new System.EventHandler(this.comboBox_assemble_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assemble:";
            // 
            // comboBox_smelter
            // 
            this.comboBox_smelter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_smelter.Enabled = false;
            this.comboBox_smelter.FormattingEnabled = true;
            this.comboBox_smelter.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_smelter.Location = new System.Drawing.Point(97, 134);
            this.comboBox_smelter.Name = "comboBox_smelter";
            this.comboBox_smelter.Size = new System.Drawing.Size(168, 23);
            this.comboBox_smelter.TabIndex = 1;
            this.comboBox_smelter.SelectedIndexChanged += new System.EventHandler(this.comboBox_smelter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smelter:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Load of Vessel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Load of Drone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Warp Distance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Charge Power:";
            // 
            // numericUpDown_vessel
            // 
            this.numericUpDown_vessel.Enabled = false;
            this.numericUpDown_vessel.Location = new System.Drawing.Point(145, 301);
            this.numericUpDown_vessel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_vessel.Name = "numericUpDown_vessel";
            this.numericUpDown_vessel.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_vessel.TabIndex = 4;
            this.numericUpDown_vessel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_vessel.ValueChanged += new System.EventHandler(this.numericUpDown_vessel_ValueChanged);
            // 
            // numericUpDown_drone
            // 
            this.numericUpDown_drone.Enabled = false;
            this.numericUpDown_drone.Location = new System.Drawing.Point(145, 270);
            this.numericUpDown_drone.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_drone.Name = "numericUpDown_drone";
            this.numericUpDown_drone.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_drone.TabIndex = 5;
            this.numericUpDown_drone.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_drone.ValueChanged += new System.EventHandler(this.numericUpDown_drone_ValueChanged);
            // 
            // numericUpDown_warp_distance
            // 
            this.numericUpDown_warp_distance.DecimalPlaces = 1;
            this.numericUpDown_warp_distance.Enabled = false;
            this.numericUpDown_warp_distance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_warp_distance.Location = new System.Drawing.Point(145, 239);
            this.numericUpDown_warp_distance.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_warp_distance.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_warp_distance.Name = "numericUpDown_warp_distance";
            this.numericUpDown_warp_distance.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_warp_distance.TabIndex = 6;
            this.numericUpDown_warp_distance.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_warp_distance.ValueChanged += new System.EventHandler(this.numericUpDown_warp_distance_ValueChanged);
            // 
            // numericUpDown_charge_power
            // 
            this.numericUpDown_charge_power.Enabled = false;
            this.numericUpDown_charge_power.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_charge_power.Location = new System.Drawing.Point(145, 208);
            this.numericUpDown_charge_power.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_charge_power.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_charge_power.Name = "numericUpDown_charge_power";
            this.numericUpDown_charge_power.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_charge_power.TabIndex = 7;
            this.numericUpDown_charge_power.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_charge_power.ValueChanged += new System.EventHandler(this.numericUpDown_charge_power_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(5, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 2);
            this.label5.TabIndex = 12;
            // 
            // checkBox_station
            // 
            this.checkBox_station.AutoSize = true;
            this.checkBox_station.Location = new System.Drawing.Point(12, 174);
            this.checkBox_station.Name = "checkBox_station";
            this.checkBox_station.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_station.Size = new System.Drawing.Size(85, 19);
            this.checkBox_station.TabIndex = 13;
            this.checkBox_station.Text = "Station";
            this.checkBox_station.UseVisualStyleBackColor = true;
            this.checkBox_station.CheckedChanged += new System.EventHandler(this.checkBox_station_CheckedChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(15, 429);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // groupBox_attr
            // 
            this.groupBox_attr.Controls.Add(this.radioButton_extra);
            this.groupBox_attr.Controls.Add(this.radioButton_speed);
            this.groupBox_attr.Enabled = false;
            this.groupBox_attr.Location = new System.Drawing.Point(12, 374);
            this.groupBox_attr.Name = "groupBox_attr";
            this.groupBox_attr.Size = new System.Drawing.Size(250, 45);
            this.groupBox_attr.TabIndex = 14;
            this.groupBox_attr.TabStop = false;
            // 
            // radioButton_extra
            // 
            this.radioButton_extra.AutoSize = true;
            this.radioButton_extra.Location = new System.Drawing.Point(176, 18);
            this.radioButton_extra.Name = "radioButton_extra";
            this.radioButton_extra.Size = new System.Drawing.Size(68, 19);
            this.radioButton_extra.TabIndex = 0;
            this.radioButton_extra.TabStop = true;
            this.radioButton_extra.Text = "Extra";
            this.radioButton_extra.UseVisualStyleBackColor = true;
            this.radioButton_extra.CheckedChanged += new System.EventHandler(this.radioButton_extra_CheckedChanged);
            // 
            // radioButton_speed
            // 
            this.radioButton_speed.AutoSize = true;
            this.radioButton_speed.Location = new System.Drawing.Point(6, 18);
            this.radioButton_speed.Name = "radioButton_speed";
            this.radioButton_speed.Size = new System.Drawing.Size(68, 19);
            this.radioButton_speed.TabIndex = 0;
            this.radioButton_speed.TabStop = true;
            this.radioButton_speed.Text = "Speed";
            this.radioButton_speed.UseVisualStyleBackColor = true;
            this.radioButton_speed.CheckedChanged += new System.EventHandler(this.radioButton_speed_CheckedChanged);
            // 
            // checkBox_attr
            // 
            this.checkBox_attr.AutoSize = true;
            this.checkBox_attr.Location = new System.Drawing.Point(12, 349);
            this.checkBox_attr.Name = "checkBox_attr";
            this.checkBox_attr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_attr.Size = new System.Drawing.Size(125, 19);
            this.checkBox_attr.TabIndex = 13;
            this.checkBox_attr.Text = "Proliferator";
            this.checkBox_attr.UseVisualStyleBackColor = true;
            this.checkBox_attr.CheckedChanged += new System.EventHandler(this.checkBox_attr_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(3, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 2);
            this.label4.TabIndex = 15;
            // 
            // checkBox_level
            // 
            this.checkBox_level.AutoSize = true;
            this.checkBox_level.Location = new System.Drawing.Point(12, 12);
            this.checkBox_level.Name = "checkBox_level";
            this.checkBox_level.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_level.Size = new System.Drawing.Size(69, 19);
            this.checkBox_level.TabIndex = 13;
            this.checkBox_level.Text = "Level";
            this.checkBox_level.UseVisualStyleBackColor = true;
            this.checkBox_level.CheckedChanged += new System.EventHandler(this.checkBox_level_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox_attr);
            this.Controls.Add(this.checkBox_attr);
            this.Controls.Add(this.checkBox_level);
            this.Controls.Add(this.checkBox_station);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_vessel);
            this.Controls.Add(this.numericUpDown_drone);
            this.Controls.Add(this.numericUpDown_warp_distance);
            this.Controls.Add(this.numericUpDown_charge_power);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_smelter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_assemble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_sorter);
            this.Controls.Add(this.label_belt_level);
            this.Controls.Add(this.comboBox_belt);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Params";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vessel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_drone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_warp_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_charge_power)).EndInit();
            this.groupBox_attr.ResumeLayout(false);
            this.groupBox_attr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.ComboBox comboBox_belt;
        private System.Windows.Forms.Label label_belt_level;
        private System.Windows.Forms.ComboBox comboBox_sorter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_assemble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_smelter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_vessel;
        private System.Windows.Forms.NumericUpDown numericUpDown_drone;
        private System.Windows.Forms.NumericUpDown numericUpDown_warp_distance;
        private System.Windows.Forms.NumericUpDown numericUpDown_charge_power;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_station;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.GroupBox groupBox_attr;
        private System.Windows.Forms.RadioButton radioButton_extra;
        private System.Windows.Forms.RadioButton radioButton_speed;
        private System.Windows.Forms.CheckBox checkBox_attr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_level;
    }
}