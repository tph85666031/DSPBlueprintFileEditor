using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPBlueprintFileEditor
{
    public partial class Form5 : Form
    {
        private int result = 0;
        private float pos_x = 0;
        private float pos_y = 0;
        private float pos_z = 0;
        private int angle = 0;

        private bool x_modified = false;
        private bool y_modified = false;
        private bool z_modified = false;
        private bool a_modified = false;

        public Form5(float pos_x, float pos_y, float pos_z,int angle)
        {
            this.pos_x = pos_x;
            this.pos_y = pos_y;
            this.pos_z = pos_z;
            this.angle = angle;

            InitializeComponent();

            numericUpDown_x.Enabled = checkBox_x.Checked;
            numericUpDown_y.Enabled = checkBox_y.Checked;
            numericUpDown_z.Enabled = checkBox_z.Checked;
            numericUpDown_a.Enabled = checkBox_a.Checked;

            numericUpDown_x.Minimum = decimal.MinValue;
            numericUpDown_x.Maximum = decimal.MaxValue;
            numericUpDown_y.Minimum = decimal.MinValue;
            numericUpDown_y.Maximum = decimal.MaxValue;
            numericUpDown_z.Minimum = decimal.MinValue;
            numericUpDown_z.Maximum = decimal.MaxValue;

            numericUpDown_x.Value = (decimal)pos_x;
            numericUpDown_y.Value = (decimal)pos_y;
            numericUpDown_z.Value = (decimal)pos_z;
            numericUpDown_a.Value = angle;
        }

        public int getResult()
        {
            return result;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.result = 1;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public float getX()
        {
            return pos_x;
        }

        public float getY()
        {
            return pos_y;
        }

        public float getZ()
        {
            return pos_z;
        }
        public int getA()
        {
            return angle;
        }

        public bool isXModified()
        {
            return x_modified;
        }

        public bool isYModified()
        {
            return y_modified;
        }

        public bool isZModified()
        {
            return z_modified;
        }

        public bool isAModified()
        {
            return a_modified;
        }

        private void numericUpDown_x_ValueChanged(object sender, EventArgs e)
        {
            this.pos_x = (float)numericUpDown_x.Value;
        }

        private void numericUpDown_y_ValueChanged(object sender, EventArgs e)
        {
            this.pos_y = (float)numericUpDown_y.Value;
        }

        private void numericUpDown_z_ValueChanged(object sender, EventArgs e)
        {
            this.pos_z = (float)numericUpDown_z.Value;
        }

        private void numericUpDown_a_ValueChanged(object sender, EventArgs e)
        {
            this.angle = (int)numericUpDown_a.Value;
        }

        private void checkBox_x_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_x.Enabled = checkBox_x.Checked;
            x_modified= checkBox_x.Checked;
        }

        private void checkBox_y_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_y.Enabled = checkBox_y.Checked;
            y_modified = checkBox_y.Checked;
        }

        private void checkBox_z_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_z.Enabled = checkBox_z.Checked;
            z_modified = checkBox_z.Checked;
        }

        private void checkBox_a_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_a.Enabled = checkBox_a.Checked;
            a_modified = checkBox_a.Checked;
        }
    }
}
