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
        public Form4(int recipe_id)
        {
            this.recipe_id = recipe_id;
            InitializeComponent();

            List<String> recipes_str = Config.getRecipesAsString();
            comboBox_recipe.DataSource = recipes_str;
            comboBox_recipe.Text = Config.getRecipeAsString(recipe_id);
        }

        public int getResult()
        {
            return result;
        }

        public int getRecipeId()
        {
            return this.recipe_id;
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
    }
}
