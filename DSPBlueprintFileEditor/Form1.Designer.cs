namespace DSPBlueprintFileEditor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_load = new System.Windows.Forms.Button();
            this.listViewStructures = new System.Windows.Forms.ListView();
            this.columnHeader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_recipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_save = new System.Windows.Forms.Button();
            this.button_save_as = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.button_batch_set = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seetPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_show_belt = new System.Windows.Forms.CheckBox();
            this.checkBox_show_all = new System.Windows.Forms.CheckBox();
            this.chart_belt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_belt)).BeginInit();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(12, 12);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(85, 23);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // listViewStructures
            // 
            this.listViewStructures.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewStructures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStructures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_nid,
            this.columnHeader_name,
            this.columnHeader_recipe,
            this.columnHeader_x,
            this.columnHeader_y,
            this.columnHeader_z,
            this.columnHeader_a});
            this.listViewStructures.FullRowSelect = true;
            this.listViewStructures.GridLines = true;
            this.listViewStructures.Location = new System.Drawing.Point(282, 65);
            this.listViewStructures.Name = "listViewStructures";
            this.listViewStructures.Size = new System.Drawing.Size(611, 366);
            this.listViewStructures.TabIndex = 1;
            this.listViewStructures.UseCompatibleStateImageBehavior = false;
            this.listViewStructures.View = System.Windows.Forms.View.Details;
            this.listViewStructures.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewStructures_ColumnClick);
            this.listViewStructures.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewStructures_MouseClick);
            this.listViewStructures.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewStructures_MouseDoubleClick);
            this.listViewStructures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewStructures_MouseUp);
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "ID";
            // 
            // columnHeader_nid
            // 
            this.columnHeader_nid.Text = "NID";
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            this.columnHeader_name.Width = 120;
            // 
            // columnHeader_recipe
            // 
            this.columnHeader_recipe.Text = "Recipe";
            this.columnHeader_recipe.Width = 120;
            // 
            // columnHeader_x
            // 
            this.columnHeader_x.Text = "X";
            // 
            // columnHeader_y
            // 
            this.columnHeader_y.Text = "Y";
            // 
            // columnHeader_z
            // 
            this.columnHeader_z.Text = "Z";
            // 
            // columnHeader_a
            // 
            this.columnHeader_a.Text = "Angle";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(103, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_save_as
            // 
            this.button_save_as.Location = new System.Drawing.Point(205, 12);
            this.button_save_as.Name = "button_save_as";
            this.button_save_as.Size = new System.Drawing.Size(85, 23);
            this.button_save_as.TabIndex = 2;
            this.button_save_as.Text = "SaveAs";
            this.button_save_as.UseVisualStyleBackColor = true;
            this.button_save_as.Click += new System.EventHandler(this.button_save_as_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(9, 47);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 15);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Name:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(9, 93);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(103, 15);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Description:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 65);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(264, 25);
            this.textBox_name.TabIndex = 5;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_desc.Location = new System.Drawing.Point(12, 111);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(264, 93);
            this.textBox_desc.TabIndex = 5;
            this.textBox_desc.TextChanged += new System.EventHandler(this.textBox_desc_TextChanged);
            // 
            // button_batch_set
            // 
            this.button_batch_set.Location = new System.Drawing.Point(296, 12);
            this.button_batch_set.Name = "button_batch_set";
            this.button_batch_set.Size = new System.Drawing.Size(96, 23);
            this.button_batch_set.TabIndex = 6;
            this.button_batch_set.Text = "BatchSet";
            this.button_batch_set.UseVisualStyleBackColor = true;
            this.button_batch_set.Click += new System.EventHandler(this.button_batch_set_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRecipeToolStripMenuItem,
            this.seetPositionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 52);
            // 
            // setRecipeToolStripMenuItem
            // 
            this.setRecipeToolStripMenuItem.Name = "setRecipeToolStripMenuItem";
            this.setRecipeToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.setRecipeToolStripMenuItem.Text = "Set Recipe";
            this.setRecipeToolStripMenuItem.Click += new System.EventHandler(this.setRecipeToolStripMenuItem_Click);
            // 
            // seetPositionToolStripMenuItem
            // 
            this.seetPositionToolStripMenuItem.Name = "seetPositionToolStripMenuItem";
            this.seetPositionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.seetPositionToolStripMenuItem.Text = "Set Position";
            this.seetPositionToolStripMenuItem.Click += new System.EventHandler(this.setPositionToolStripMenuItem_Click);
            // 
            // checkBox_show_belt
            // 
            this.checkBox_show_belt.AutoSize = true;
            this.checkBox_show_belt.Enabled = false;
            this.checkBox_show_belt.Location = new System.Drawing.Point(398, 15);
            this.checkBox_show_belt.Name = "checkBox_show_belt";
            this.checkBox_show_belt.Size = new System.Drawing.Size(93, 19);
            this.checkBox_show_belt.TabIndex = 7;
            this.checkBox_show_belt.Text = "ShowBelt";
            this.checkBox_show_belt.UseVisualStyleBackColor = true;
            this.checkBox_show_belt.CheckedChanged += new System.EventHandler(this.checkBox_show_belt_CheckedChanged);
            // 
            // checkBox_show_all
            // 
            this.checkBox_show_all.AutoSize = true;
            this.checkBox_show_all.Enabled = false;
            this.checkBox_show_all.Location = new System.Drawing.Point(497, 15);
            this.checkBox_show_all.Name = "checkBox_show_all";
            this.checkBox_show_all.Size = new System.Drawing.Size(85, 19);
            this.checkBox_show_all.TabIndex = 7;
            this.checkBox_show_all.Text = "ShowAll";
            this.checkBox_show_all.UseVisualStyleBackColor = true;
            this.checkBox_show_all.CheckedChanged += new System.EventHandler(this.checkBox_show_all_CheckedChanged);
            // 
            // chart_belt
            // 
            this.chart_belt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chart_belt.ChartAreas.Add(chartArea1);
            this.chart_belt.Location = new System.Drawing.Point(12, 210);
            this.chart_belt.Name = "chart_belt";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart_belt.Series.Add(series1);
            this.chart_belt.Size = new System.Drawing.Size(264, 221);
            this.chart_belt.TabIndex = 8;
            this.chart_belt.Visible = false;
            this.chart_belt.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart_belt_GetToolTipText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 443);
            this.Controls.Add(this.chart_belt);
            this.Controls.Add(this.checkBox_show_all);
            this.Controls.Add(this.checkBox_show_belt);
            this.Controls.Add(this.button_batch_set);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_save_as);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.listViewStructures);
            this.Controls.Add(this.button_load);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSPBlueprintFileEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_belt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ListView listViewStructures;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_save_as;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.ColumnHeader columnHeader_nid;
        private System.Windows.Forms.Button button_batch_set;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setRecipeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader_recipe;
        private System.Windows.Forms.ToolStripMenuItem seetPositionToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_show_belt;
        private System.Windows.Forms.CheckBox checkBox_show_all;
        private System.Windows.Forms.ColumnHeader columnHeader_x;
        private System.Windows.Forms.ColumnHeader columnHeader_y;
        private System.Windows.Forms.ColumnHeader columnHeader_z;
        private System.Windows.Forms.ColumnHeader columnHeader_a;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_belt;
    }
}

