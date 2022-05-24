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
    public partial class Form4 : Form
    {
        private int result = 0;
        private int recipe_id = 0;
        private bool attr_speed = true;
        public Form4(int recipe_id, bool attr_speed)
        {
            this.recipe_id = recipe_id;
            InitializeComponent();

            List<String> recipes_str = Config.getRecipesAsString();
            comboBox_recipe.DataSource = recipes_str;
            comboBox_recipe.Text = Config.getRecipeAsString(recipe_id);
            radioButton_speed.Checked = attr_speed;
            radioButton_extra.Checked = !attr_speed;
            this.attr_speed = attr_speed;
        }

        public int getResult()
        {
            return result;
        }

        public int getRecipeId()
        {
            return recipe_id;
        }

        public bool isAttrSpeed()
        {
            return attr_speed;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private int getRecipeIdFromComboBox(ref ComboBox combobox)
        {
            string text = combobox.SelectedValue.ToString();
            if (text== "0,Empty" || text == "0,空")
            {
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

        private void comboBox_recipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_recipe.SelectedValue.ToString();
            this.recipe_id = getRecipeIdFromComboBox(ref comboBox_recipe);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_speed_CheckedChanged(object sender, EventArgs e)
        {
            attr_speed = radioButton_speed.Checked;
        }

        private void radioButton_extra_CheckedChanged(object sender, EventArgs e)
        {
            attr_speed = radioButton_speed.Checked;
        }
    }
}
