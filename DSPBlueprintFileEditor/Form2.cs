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
    public partial class Form2 : Form
    {
        public int belt_level = 0;
        public int sorter_level = 0;
        public int assemble_level = 0;
        public int smelter_level = 0;

        public int charge_power = 60;
        public decimal warp_distance = 12;
        public int drone_load = 10;
        public int vessel_load = 100;

        private int result = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_belt.SelectedIndex = belt_level;
            comboBox_smelter.SelectedIndex = sorter_level;
            comboBox_sorter.SelectedIndex = assemble_level;
            comboBox_assemble.SelectedIndex = smelter_level;
            numericUpDown_charge_power.Value = charge_power;
            numericUpDown_warp_distance.Value = warp_distance;
            numericUpDown_drone.Value = drone_load;
            numericUpDown_vessel.Value = vessel_load;
        }

        public int getResult()
        {
            return result;
        }

        public bool isStationModified()
        {
            return checkBox_station.Enabled;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_belt_SelectedIndexChanged(object sender, EventArgs e)
        {
            belt_level = comboBox_belt.SelectedIndex;
        }

        private void comboBox_sorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorter_level = comboBox_sorter.SelectedIndex;
        }

        private void comboBox_assemble_SelectedIndexChanged(object sender, EventArgs e)
        {
            assemble_level = comboBox_assemble.SelectedIndex;
        }

        private void comboBox_smelter_SelectedIndexChanged(object sender, EventArgs e)
        {
            smelter_level = comboBox_smelter.SelectedIndex;
        }

        private void checkBox_station_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_charge_power.Enabled = checkBox_station.Checked;
            numericUpDown_warp_distance.Enabled = checkBox_station.Checked;
            numericUpDown_drone.Enabled = checkBox_station.Checked;
            numericUpDown_vessel.Enabled = checkBox_station.Checked;
        }

        private void numericUpDown_charge_power_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_charge_power.Enabled)
            {
                charge_power = (int)numericUpDown_charge_power.Value;
            }
        }

        private void numericUpDown_warp_distance_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_warp_distance.Enabled)
            {
                warp_distance = (int)numericUpDown_warp_distance.Value;
            }
        }

        private void numericUpDown_drone_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_drone.Enabled)
            {
                drone_load = (int)numericUpDown_drone.Value;
            }
        }

        private void numericUpDown_vessel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_vessel.Enabled)
            {
                vessel_load = (int)numericUpDown_vessel.Value;
            }
        }
    }
}
