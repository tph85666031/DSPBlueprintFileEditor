namespace DSPBlueprintFileEditor
{
    partial class Form5
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
            this.label_x = new System.Windows.Forms.Label();
            this.numericUpDown_x = new System.Windows.Forms.NumericUpDown();
            this.label_y = new System.Windows.Forms.Label();
            this.numericUpDown_y = new System.Windows.Forms.NumericUpDown();
            this.label_z = new System.Windows.Forms.Label();
            this.numericUpDown_z = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_x = new System.Windows.Forms.CheckBox();
            this.checkBox_y = new System.Windows.Forms.CheckBox();
            this.checkBox_z = new System.Windows.Forms.CheckBox();
            this.label_a = new System.Windows.Forms.Label();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.checkBox_a = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            this.SuspendLayout();
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(12, 9);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(15, 15);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "X";
            // 
            // numericUpDown_x
            // 
            this.numericUpDown_x.DecimalPlaces = 6;
            this.numericUpDown_x.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown_x.Location = new System.Drawing.Point(33, 7);
            this.numericUpDown_x.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_x.Name = "numericUpDown_x";
            this.numericUpDown_x.Size = new System.Drawing.Size(138, 25);
            this.numericUpDown_x.TabIndex = 1;
            this.numericUpDown_x.ValueChanged += new System.EventHandler(this.numericUpDown_x_ValueChanged);
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(12, 40);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(15, 15);
            this.label_y.TabIndex = 0;
            this.label_y.Text = "Y";
            // 
            // numericUpDown_y
            // 
            this.numericUpDown_y.DecimalPlaces = 6;
            this.numericUpDown_y.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown_y.Location = new System.Drawing.Point(33, 38);
            this.numericUpDown_y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_y.Name = "numericUpDown_y";
            this.numericUpDown_y.Size = new System.Drawing.Size(138, 25);
            this.numericUpDown_y.TabIndex = 1;
            this.numericUpDown_y.ValueChanged += new System.EventHandler(this.numericUpDown_y_ValueChanged);
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(12, 71);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(15, 15);
            this.label_z.TabIndex = 0;
            this.label_z.Text = "Z";
            // 
            // numericUpDown_z
            // 
            this.numericUpDown_z.DecimalPlaces = 6;
            this.numericUpDown_z.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_z.Location = new System.Drawing.Point(33, 69);
            this.numericUpDown_z.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_z.Name = "numericUpDown_z";
            this.numericUpDown_z.Size = new System.Drawing.Size(138, 25);
            this.numericUpDown_z.TabIndex = 1;
            this.numericUpDown_z.ValueChanged += new System.EventHandler(this.numericUpDown_z_ValueChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(15, 150);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(115, 150);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_x
            // 
            this.checkBox_x.AutoSize = true;
            this.checkBox_x.Location = new System.Drawing.Point(177, 9);
            this.checkBox_x.Name = "checkBox_x";
            this.checkBox_x.Size = new System.Drawing.Size(18, 17);
            this.checkBox_x.TabIndex = 4;
            this.checkBox_x.UseVisualStyleBackColor = true;
            this.checkBox_x.CheckedChanged += new System.EventHandler(this.checkBox_x_CheckedChanged);
            // 
            // checkBox_y
            // 
            this.checkBox_y.AutoSize = true;
            this.checkBox_y.Location = new System.Drawing.Point(177, 40);
            this.checkBox_y.Name = "checkBox_y";
            this.checkBox_y.Size = new System.Drawing.Size(18, 17);
            this.checkBox_y.TabIndex = 4;
            this.checkBox_y.UseVisualStyleBackColor = true;
            this.checkBox_y.CheckedChanged += new System.EventHandler(this.checkBox_y_CheckedChanged);
            // 
            // checkBox_z
            // 
            this.checkBox_z.AutoSize = true;
            this.checkBox_z.Location = new System.Drawing.Point(177, 71);
            this.checkBox_z.Name = "checkBox_z";
            this.checkBox_z.Size = new System.Drawing.Size(18, 17);
            this.checkBox_z.TabIndex = 4;
            this.checkBox_z.UseVisualStyleBackColor = true;
            this.checkBox_z.CheckedChanged += new System.EventHandler(this.checkBox_z_CheckedChanged);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(12, 102);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(15, 15);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "A";
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Location = new System.Drawing.Point(33, 100);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(138, 25);
            this.numericUpDown_a.TabIndex = 1;
            this.numericUpDown_a.ValueChanged += new System.EventHandler(this.numericUpDown_a_ValueChanged);
            // 
            // checkBox_a
            // 
            this.checkBox_a.AutoSize = true;
            this.checkBox_a.Location = new System.Drawing.Point(177, 102);
            this.checkBox_a.Name = "checkBox_a";
            this.checkBox_a.Size = new System.Drawing.Size(18, 17);
            this.checkBox_a.TabIndex = 4;
            this.checkBox_a.UseVisualStyleBackColor = true;
            this.checkBox_a.CheckedChanged += new System.EventHandler(this.checkBox_a_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 185);
            this.Controls.Add(this.checkBox_a);
            this.Controls.Add(this.checkBox_z);
            this.Controls.Add(this.checkBox_y);
            this.Controls.Add(this.checkBox_x);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.numericUpDown_a);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.numericUpDown_z);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.numericUpDown_y);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.numericUpDown_x);
            this.Controls.Add(this.label_x);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Position";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.NumericUpDown numericUpDown_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.NumericUpDown numericUpDown_y;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.NumericUpDown numericUpDown_z;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox checkBox_x;
        private System.Windows.Forms.CheckBox checkBox_y;
        private System.Windows.Forms.CheckBox checkBox_z;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.CheckBox checkBox_a;
    }
}