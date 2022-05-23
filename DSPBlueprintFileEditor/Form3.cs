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
    public partial class Form3 : Form
    {
        private int result = 0;
        private int[] parameters;

        public Form3(int item_id, int[] parameters)
        {
            this.parameters = parameters;

            InitializeComponent();
            List<String> items1_str = Config.getItemsAsString();
            List<String> items2_str = Config.getItemsAsString();
            List<String> items3_str = Config.getItemsAsString();
            List<String> items4_str = Config.getItemsAsString();
            List<String> items5_str = Config.getItemsAsString();

            int item1_id = parameters[Config.index_item1];
            int local_mode1 = parameters[Config.index_item1_local_mode];
            int remote_mode1 = parameters[Config.index_item1_remote_mode];
            int capacity1 = parameters[Config.index_item1_capacity];

            int item2_id = parameters[Config.index_item2];
            int local_mode2 = parameters[Config.index_item2_local_mode];
            int remote_mode2 = parameters[Config.index_item2_remote_mode];
            int capacity2 = parameters[Config.index_item2_capacity];

            int item3_id = parameters[Config.index_item3];
            int local_mode3 = parameters[Config.index_item3_local_mode];
            int remote_mode3 = parameters[Config.index_item3_remote_mode];
            int capacity3 = parameters[Config.index_item3_capacity];

            int item4_id = parameters[Config.index_item4];
            int local_mode4 = parameters[Config.index_item4_local_mode];
            int remote_mode4 = parameters[Config.index_item4_remote_mode];
            int capacity4 = parameters[Config.index_item4_capacity];

            int item5_id = parameters[Config.index_item5];
            int local_mode5 = parameters[Config.index_item5_local_mode];
            int remote_mode5 = parameters[Config.index_item5_remote_mode];
            int capacity5 = parameters[Config.index_item5_capacity];

            int power_charge = parameters[Config.index_charge_power];//充电功率
            int warp_distance = parameters[Config.index_warp_distance];//曲数启用距离
            int drone_load_min = parameters[Config.index_drone_load];//运输机起运量
            int vessel_load_min = parameters[Config.index_vessel_load];//运输船起运量

            if (power_charge > 10000000)
            {
                power_charge = 10000000;
            }

            if (power_charge < 500000)
            {
                power_charge = 500000;
            }

            if (warp_distance > 2400000)
            {
                warp_distance = 2400000;
            }

            if (warp_distance < 20000)
            {
                warp_distance = 20000;
            }

            numericUpDown_charge_power.Value = (decimal)power_charge * 30 / 500000;
            numericUpDown_warp_distance.Value = (decimal)warp_distance / 40000;
            numericUpDown_drone.Value = drone_load_min;
            numericUpDown_vessel.Value = vessel_load_min;

            comboBox1.DataSource = items1_str;
            comboBox2.DataSource = items2_str;
            comboBox3.DataSource = items3_str;
            comboBox4.DataSource = items4_str;
            comboBox5.DataSource = items5_str;

            comboBox1.Text = Config.getItemAsString(item1_id);
            comboBox2.Text = Config.getItemAsString(item2_id);
            comboBox3.Text = Config.getItemAsString(item3_id);
            comboBox4.Text = Config.getItemAsString(item4_id);
            comboBox5.Text = Config.getItemAsString(item5_id);

            numericUpDown1.Value = capacity1;
            numericUpDown2.Value = capacity2;
            numericUpDown3.Value = capacity3;
            numericUpDown4.Value = capacity4;
            numericUpDown5.Value = capacity5;

            numericUpDown1_local.Value = local_mode1;
            numericUpDown2_local.Value = local_mode2;
            numericUpDown3_local.Value = local_mode3;
            numericUpDown4_local.Value = local_mode4;
            numericUpDown5_local.Value = local_mode5;

            numericUpDown1_remote.Value = remote_mode1;
            numericUpDown2_remote.Value = remote_mode2;
            numericUpDown3_remote.Value = remote_mode3;
            numericUpDown4_remote.Value = remote_mode4;
            numericUpDown5_remote.Value = remote_mode5;

            if (Config.isGalaxyStation(item_id) == false)
            {
                numericUpDown1.Maximum = 10000;
                numericUpDown2.Maximum = 10000;
                numericUpDown3.Maximum = 10000;
                numericUpDown4.Maximum = 10000;
                numericUpDown5.Maximum = 10000;

                comboBox4.Enabled = false;
                comboBox5.Enabled = false;

                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;

                numericUpDown_warp_distance.Enabled = false;
                numericUpDown_vessel.Enabled = false;

                numericUpDown4_local.Enabled = false;
                numericUpDown5_local.Enabled = false;

                numericUpDown1_remote.Enabled = false;
                numericUpDown2_remote.Enabled = false;
                numericUpDown3_remote.Enabled = false;
                numericUpDown4_remote.Enabled = false;
                numericUpDown5_remote.Enabled = false;
            }
        }

        public int[] getParameters()
        {
            return parameters;
        }

        public int getResult()
        {
            return result;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private int getItemIdFromComboBox(ref ComboBox combobox)
        {
            string text = combobox.SelectedValue.ToString();
            if (text == "0,Empty" || text == "0,空")
            {
                parameters[Config.index_item1] = 0;
                return 0;
            }
            string[] vals = text.Split(',');
            if (vals.Length != 2)
            {
                return 0;
            }

            int item_id = 0;
            Int32.TryParse(vals[0], out item_id);
            return item_id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item1] = getItemIdFromComboBox(ref comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item2] = getItemIdFromComboBox(ref comboBox2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item3] = getItemIdFromComboBox(ref comboBox3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item4] = getItemIdFromComboBox(ref comboBox4);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item5] = getItemIdFromComboBox(ref comboBox5);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item1_capacity] = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item2_capacity] = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item3_capacity] = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item4_capacity] = (int)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item5_capacity] = (int)numericUpDown5.Value;
        }

        private void numericUpDown_charge_power_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_charge_power] = (int)(numericUpDown_charge_power.Value * 500000 / 30);
        }

        private void numericUpDown_warp_distance_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_warp_distance] = (int)(numericUpDown_warp_distance.Value * 40000);
        }

        private void numericUpDown_drone_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_drone_load] = (int)(numericUpDown_drone.Value);
        }

        private void numericUpDown_vessel_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_vessel_load] = (int)(numericUpDown_vessel.Value);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_local_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item1_local_mode] = (int)numericUpDown1_local.Value;
        }

        private void numericUpDown2_local_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item2_local_mode] = (int)numericUpDown2_local.Value;
        }

        private void numericUpDown3_local_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item3_local_mode] = (int)numericUpDown3_local.Value;
        }

        private void numericUpDown4_local_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item4_local_mode] = (int)numericUpDown4_local.Value;
        }

        private void numericUpDown5_local_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item5_local_mode] = (int)numericUpDown5_local.Value;
        }

        private void numericUpDown1_remote_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item1_remote_mode] = (int)numericUpDown1_remote.Value;
        }

        private void numericUpDown2_remote_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item2_remote_mode] = (int)numericUpDown2_remote.Value;
        }

        private void numericUpDown3_remote_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item3_remote_mode] = (int)numericUpDown3_remote.Value;
        }

        private void numericUpDown4_remote_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item4_remote_mode] = (int)numericUpDown4_remote.Value;
        }

        private void numericUpDown5_remote_ValueChanged(object sender, EventArgs e)
        {
            parameters[Config.index_item5_remote_mode] = (int)numericUpDown5_remote.Value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
