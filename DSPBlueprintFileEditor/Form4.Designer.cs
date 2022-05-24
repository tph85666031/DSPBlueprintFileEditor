namespace DSPBlueprintFileEditor
{
    partial class Form4
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
            this.comboBox_recipe = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_speed = new System.Windows.Forms.RadioButton();
            this.radioButton_extra = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_recipe
            // 
            this.comboBox_recipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_recipe.FormattingEnabled = true;
            this.comboBox_recipe.Location = new System.Drawing.Point(12, 12);
            this.comboBox_recipe.Name = "comboBox_recipe";
            this.comboBox_recipe.Size = new System.Drawing.Size(194, 23);
            this.comboBox_recipe.TabIndex = 0;
            this.comboBox_recipe.SelectedIndexChanged += new System.EventHandler(this.comboBox_recipe_SelectedIndexChanged);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(131, 97);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 97);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_speed
            // 
            this.radioButton_speed.AutoSize = true;
            this.radioButton_speed.Location = new System.Drawing.Point(8, 11);
            this.radioButton_speed.Name = "radioButton_speed";
            this.radioButton_speed.Size = new System.Drawing.Size(68, 19);
            this.radioButton_speed.TabIndex = 0;
            this.radioButton_speed.TabStop = true;
            this.radioButton_speed.Text = "Speed";
            this.radioButton_speed.UseVisualStyleBackColor = true;
            this.radioButton_speed.CheckedChanged += new System.EventHandler(this.radioButton_speed_CheckedChanged);
            // 
            // radioButton_extra
            // 
            this.radioButton_extra.AutoSize = true;
            this.radioButton_extra.Location = new System.Drawing.Point(119, 11);
            this.radioButton_extra.Name = "radioButton_extra";
            this.radioButton_extra.Size = new System.Drawing.Size(68, 19);
            this.radioButton_extra.TabIndex = 0;
            this.radioButton_extra.TabStop = true;
            this.radioButton_extra.Text = "Extra";
            this.radioButton_extra.UseVisualStyleBackColor = true;
            this.radioButton_extra.CheckedChanged += new System.EventHandler(this.radioButton_extra_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_extra);
            this.groupBox1.Controls.Add(this.radioButton_speed);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 132);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox_recipe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recipe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_recipe;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton radioButton_speed;
        private System.Windows.Forms.RadioButton radioButton_extra;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}