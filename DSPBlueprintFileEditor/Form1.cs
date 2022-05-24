using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSPBlueprintFileEditor
{
    public partial class Form1 : Form
    {
        private BlueprintData bd;
        private string file_blue_print;

        public Form1()
        {
            InitializeComponent();
        }

        private void reloadListViewSelected()
        {
            listViewStructures.BeginUpdate();
            for (int i = 0; i < listViewStructures.SelectedItems.Count; i++)
            {
                int id = Int32.Parse(listViewStructures.SelectedItems[i].SubItems[0].Text);
                int item_id = Int32.Parse(listViewStructures.SelectedItems[i].SubItems[1].Text);
                listViewStructures.SelectedItems[i].SubItems[1].Text = item_id.ToString();
                listViewStructures.SelectedItems[i].SubItems[2].Text = Config.items[item_id];
                if (Config.hasRecipe(item_id))
                {
                    listViewStructures.SelectedItems[i].SubItems[3].Text = Config.recipes[bd.buildings[id].recipeId];
                }
                else
                {
                    listViewStructures.SelectedItems[i].SubItems[3].Text = "";
                }
                listViewStructures.SelectedItems[i].SubItems[4].Text = bd.buildings[id].localOffset_x.ToString("F6");
                listViewStructures.SelectedItems[i].SubItems[5].Text = bd.buildings[id].localOffset_y.ToString("F6");
                listViewStructures.SelectedItems[i].SubItems[6].Text = bd.buildings[id].localOffset_z.ToString("F6");
                listViewStructures.SelectedItems[i].SubItems[7].Text = bd.buildings[id].yaw.ToString("F0");
            }

            listViewStructures.Columns[0].Width = -1;
            listViewStructures.Columns[1].Width = -1;
            listViewStructures.Columns[2].Width = -1;
            listViewStructures.Columns[3].Width = -2;
            listViewStructures.Columns[4].Width = -1;
            listViewStructures.Columns[5].Width = -1;
            listViewStructures.Columns[6].Width = -1;
            listViewStructures.Columns[7].Width = -2;
            listViewStructures.EndUpdate();
            return;
        }

        private void reloadListView()
        {
            listViewStructures.BeginUpdate();
            listViewStructures.Items.Clear();

            for (int i = 0; i < bd.buildings.Length; i++)
            {
                BlueprintBuilding bb = bd.buildings[i];
                bool ignore = true;
                if (Config.isStation(bb.itemId) || Config.hasRecipe(bb.itemId))
                {
                    ignore = false;
                }
                else if (Config.isBelt(bb.itemId) && (checkBox_show_belt.Checked || checkBox_show_all.Checked))
                {
                    ignore = false;
                }
                else if (checkBox_show_all.Checked)
                {
                    ignore = false;
                }

                if (ignore)
                {
                    continue;
                }

                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(bb.itemId.ToString());
                item.SubItems.Add(Config.items[bb.itemId]);
                if (Config.hasRecipe(bb.itemId))
                {
                    item.SubItems.Add(Config.recipes[bb.recipeId]);
                }
                else
                {
                    item.SubItems.Add("");
                }
                item.SubItems.Add(bb.localOffset_x.ToString("F6"));
                item.SubItems.Add(bb.localOffset_y.ToString("F6"));
                item.SubItems.Add(bb.localOffset_z.ToString("F6"));
                item.SubItems.Add(bb.yaw.ToString("F0"));
                listViewStructures.Items.Add(item);
            }
            listViewStructures.Columns[0].Width = -1;
            listViewStructures.Columns[1].Width = -1;
            listViewStructures.Columns[2].Width = -1;
            listViewStructures.Columns[3].Width = -2;
            listViewStructures.Columns[4].Width = -1;
            listViewStructures.Columns[5].Width = -1;
            listViewStructures.Columns[6].Width = -1;
            listViewStructures.Columns[7].Width = -2;
            listViewStructures.EndUpdate();
            return;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BluePrintFile|*.txt";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            file_blue_print = ofd.FileName;
            bd = new BlueprintData();
            bd.LoadBlueprintData(file_blue_print);
            textBox_name.Text = bd.shortDesc;
            textBox_desc.Text = bd.desc;
            reloadListView();
            reloadChart();
            button_batch_set.Enabled = true;
            checkBox_show_belt.Enabled = true;
            checkBox_show_all.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bd.SaveBlueprintData(file_blue_print);
        }

        private void button_save_as_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BluePrintFile|*.txt";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            file_blue_print = sfd.FileName;
            bd.SaveBlueprintData(file_blue_print);
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            bd.shortDesc = textBox_name.Text;
        }

        private void textBox_desc_TextChanged(object sender, EventArgs e)
        {
            bd.desc = textBox_desc.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewStructures.FullRowSelect = true;
            button_batch_set.Enabled = false;
            checkBox_show_all.Enabled = false;
            checkBox_show_belt.Enabled = false;

            chart_belt.Series[0].ChartType = SeriesChartType.FastPoint;

            chart_belt.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart_belt.ChartAreas[0].AxisY.IsStartedFromZero = true;

            chart_belt.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart_belt.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart_belt.ChartAreas[0].AxisX.Interval = 1;
            chart_belt.ChartAreas[0].AxisY.Interval = 1;
            //chart_belt.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //chart_belt.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart_belt.Series[0].MarkerStyle = MarkerStyle.Circle; //指定标记样式
            chart_belt.Series[0].MarkerSize = 6;
            chart_belt.Series[0].IsValueShownAsLabel = true;
            //chart1.Series[0].Color = Color.Green;
        }

        private void listViewStructures_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listViewStructures.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Show(listViewStructures, e.Location);
            }
            else if (e.Button == MouseButtons.Left && listViewStructures.SelectedItems.Count == 1 && chart_belt.Visible)
            {
                int selected_count = listViewStructures.SelectedItems.Count;
                ListViewItem item_first = listViewStructures.SelectedItems[0];
                int id = Int32.Parse(item_first.SubItems[0].Text);
                int item_id = Int32.Parse(item_first.SubItems[1].Text);

                for (int i = 0; i < chart_belt.Series[0].Points.Count; i++)
                {
                    double offset_1 = Math.Abs(bd.buildings[id].localOffset_x - chart_belt.Series[0].Points[i].XValue);
                    double offset_2 = Math.Abs(bd.buildings[id].localOffset_y - chart_belt.Series[0].Points[i].YValues[0]);
                    if (offset_1 < 0.001 && offset_2 < 0.001)
                    {
                        chart_belt.Series[0].Points[i].Color = Color.Red;
                        chart_belt.Series[0].Points[i].MarkerColor = Color.Red;
                        break;
                    }
                }
            }
        }

        private void listViewStructures_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                setRecipeToolStripMenuItem.Enabled = false;
                foreach (ListViewItem item in listViewStructures.SelectedItems)
                {
                    int item_id = Int32.Parse(item.SubItems[1].Text);
                    if (Config.hasRecipe(item_id))
                    {
                        setRecipeToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }

        private void setRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item_first = listViewStructures.SelectedItems[0];
            int id = Int32.Parse(item_first.SubItems[0].Text);
            int item_id = Int32.Parse(item_first.SubItems[1].Text);
            int recipe_id = bd.buildings[id].recipeId;
            bool attr_speed = true;
            if (Config.hasRecipe(item_id) && bd.buildings[id].parameters != null && bd.buildings[id].parameters.Length == 1)
            {
                attr_speed = (bd.buildings[id].parameters[Config.index_proliferator] == 1);
            }
            Form4 f = new Form4(recipe_id, attr_speed);
            f.ShowDialog();
            if (f.getResult() != 1)
            {
                return;
            }
            foreach (ListViewItem item in listViewStructures.SelectedItems)
            {
                id = Int32.Parse(item.SubItems[0].Text);
                item_id = Int32.Parse(item.SubItems[1].Text);
                bd.buildings[id].recipeId = f.getRecipeId();
                if (Config.hasRecipe(item_id) && bd.buildings[id].parameters != null && bd.buildings[id].parameters.Length == 1)
                {
                    bd.buildings[id].parameters[Config.index_proliferator] = f.isAttrSpeed() ? 1 : 0;
                }
            }
            reloadListViewSelected();
        }

        private void listViewStructures_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewStructures.Sorting == SortOrder.Ascending)
            {
                listViewStructures.Sorting = SortOrder.Descending;
            }
            else
            {
                listViewStructures.Sorting = SortOrder.Ascending;
            }

            listViewStructures.ListViewItemSorter = new ListViewSort(e.Column, listViewStructures.Sorting);
            listViewStructures.Sort();
        }

        private void button_batch_set_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            if (f.getResult() == 1)
            {
                for (int i = 0; i < bd.buildings.Length; i++)
                {
                    BlueprintBuilding bb = bd.buildings[i];
                    if (f.isLevelModified())
                    {
                        if (bb.itemId == 2001 || bb.itemId == 2002 || bb.itemId == 2003)
                        {
                            if (f.belt_level == 0)
                            {
                                bb.itemId = 2001;
                                bb.modelIndex = 35;
                            }
                            else if (f.belt_level == 1)
                            {
                                bb.itemId = 2002;
                                bb.modelIndex = 36;
                            }
                            else if (f.belt_level == 2)
                            {
                                bb.itemId = 2003;
                                bb.modelIndex = 37;
                            }
                        }
                        else if (bb.itemId == 2011 || bb.itemId == 2012 || bb.itemId == 2013)
                        {
                            if (f.sorter_level == 0)
                            {
                                bb.itemId = 2011;
                                bb.modelIndex = 41;
                            }
                            else if (f.sorter_level == 1)
                            {
                                bb.itemId = 2012;
                                bb.modelIndex = 42;
                            }
                            else if (f.sorter_level == 2)
                            {
                                bb.itemId = 2013;
                                bb.modelIndex = 43;
                            }
                        }
                        else if (bb.itemId == 2303 || bb.itemId == 2304 || bb.itemId == 2305)
                        {
                            if (f.assemble_level == 0)
                            {
                                bb.itemId = 2303;
                                bb.modelIndex = 65;//UI
                            }
                            else if (f.assemble_level == 1)
                            {
                                bb.itemId = 2304;
                                bb.modelIndex = 66;//UI
                            }
                            else if (f.assemble_level == 2)
                            {
                                bb.itemId = 2305;
                                bb.modelIndex = 67;//UI
                            }
                        }
                        else if (bb.itemId == 2302 || bb.itemId == 2315)
                        {
                            if (f.smelter_level == 0)
                            {
                                bb.itemId = 2302;
                                bb.modelIndex = 62;//UI
                            }
                            else if (f.smelter_level == 1)
                            {
                                bb.itemId = 2315;
                                bb.modelIndex = 194;//UI
                            }
                        }
                    }
                    if (f.isProliferatorModified() && Config.hasRecipe(bb.itemId) && bb.parameters != null && bb.parameters.Length == 1)
                    {
                        bb.parameters[Config.index_proliferator] = f.isAttrSpeed() ? 1 : 0;
                    }
                    if (f.isStationModified() && Config.isStation(bb.itemId))
                    {
                        bb.parameters[Config.index_charge_power] = (int)(f.charge_power * 500000 / 30);
                        bb.parameters[Config.index_warp_distance] = (int)(f.warp_distance * 40000);
                        bb.parameters[Config.index_drone_load] = f.drone_load;
                        bb.parameters[Config.index_vessel_load] = f.vessel_load;
                    }
                }
                reloadListViewSelected();
            }
        }

        private void listViewStructures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && listViewStructures.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewStructures.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);
                int item_id = int.Parse(item.SubItems[1].Text);

                if (Config.isStation(item_id))
                {
                    Form3 f = new Form3(item_id, bd.buildings[id].parameters);
                    f.ShowDialog();
                    if (f.getResult() == 1)
                    {
                        bd.buildings[id].parameters = f.getParameters();
                    }
                }
                else if (Config.hasRecipe(item_id))
                {
                    int recipe_id = bd.buildings[id].recipeId;
                    bool attr_speed = (bd.buildings[id].parameters[Config.index_proliferator] == 1);
                    Form4 f = new Form4(recipe_id, attr_speed);
                    f.ShowDialog();
                    if (f.getResult() == 1)
                    {
                        bd.buildings[id].recipeId = f.getRecipeId();
                        bd.buildings[id].parameters[Config.index_proliferator] = f.isAttrSpeed() ? 1 : 0;
                        reloadListViewSelected();
                    }
                }
                else
                {
                    Form5 f = new Form5(bd.buildings[id].localOffset_x, bd.buildings[id].localOffset_y, bd.buildings[id].localOffset_z, (int)bd.buildings[id].yaw);
                    f.ShowDialog();
                    if (f.getResult() == 1)
                    {
                        if (f.isXModified())
                        {
                            bd.buildings[id].localOffset_x = f.getX();
                            bd.buildings[id].localOffset_x2 = f.getX();
                        }

                        if (f.isYModified())
                        {
                            bd.buildings[id].localOffset_y = f.getY();
                            bd.buildings[id].localOffset_y2 = f.getY();
                        }

                        if (f.isZModified())
                        {
                            bd.buildings[id].localOffset_z = f.getZ();
                            bd.buildings[id].localOffset_z2 = f.getZ();
                        }

                        if (f.isAModified())
                        {
                            bd.buildings[id].yaw = f.getA();
                            bd.buildings[id].yaw2 = f.getA();
                        }

                        reloadListViewSelected();
                    }
                }
            }
        }

        private void setPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected_count = listViewStructures.SelectedItems.Count;
            ListViewItem item_first = listViewStructures.SelectedItems[0];
            int id = Int32.Parse(item_first.SubItems[0].Text);
            int item_id = Int32.Parse(item_first.SubItems[1].Text);

            Form5 f = new Form5(bd.buildings[id].localOffset_x, bd.buildings[id].localOffset_y, bd.buildings[id].localOffset_z, (int)bd.buildings[id].yaw);
            f.ShowDialog();
            if (f.getResult() != 1)
            {
                return;
            }

            foreach (ListViewItem item in listViewStructures.SelectedItems)
            {
                id = Int32.Parse(item.SubItems[0].Text);
                item_id = Int32.Parse(item.SubItems[1].Text);

                if (f.isXModified())
                {
                    bd.buildings[id].localOffset_x = f.getX();
                    bd.buildings[id].localOffset_x2 = f.getX();
                }

                if (f.isYModified())
                {
                    bd.buildings[id].localOffset_y = f.getY();
                    bd.buildings[id].localOffset_y2 = f.getY();
                }

                if (f.isZModified())
                {
                    bd.buildings[id].localOffset_z = f.getZ();
                    bd.buildings[id].localOffset_z2 = f.getZ();
                }

                if (f.isAModified())
                {
                    bd.buildings[id].yaw = f.getA();
                    bd.buildings[id].yaw2 = f.getA();
                }
            }
            reloadListViewSelected();
        }

        private void reloadChart()
        {
            if (checkBox_show_belt.Checked || checkBox_show_belt.Checked)
            {
                chart_belt.Visible = true;
            }
            else
            {
                chart_belt.Visible = false;
                return;
            }

            double x_max = 0;
            double x_min = 0;
            double y_max = 0;
            double y_min = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            for (int i = 0; i < bd.buildings.Length; i++)
            {
                BlueprintBuilding bb = bd.buildings[i];
                if (Config.isBelt(bb.itemId))
                {
                    x.Add(bb.localOffset_x);
                    y.Add(bb.localOffset_y);

                    if (x_min > bb.localOffset_x)
                    {
                        x_min = bb.localOffset_x;
                    }
                    if (x_max < bb.localOffset_x)
                    {
                        x_max = bb.localOffset_x;
                    }
                    if (y_min > bb.localOffset_y)
                    {
                        y_min = bb.localOffset_y;
                    }
                    if (y_max < bb.localOffset_y)
                    {
                        y_max = bb.localOffset_y;
                    }
                }
            }
            chart_belt.Series[0].Points.Clear();
            chart_belt.Series[0].Points.DataBindXY(x, y);
            chart_belt.ChartAreas[0].AxisX.Minimum = x_min - 1;
            chart_belt.ChartAreas[0].AxisX.Maximum = x_max + 1;
            chart_belt.ChartAreas[0].AxisY.Minimum = y_min - 1;
            chart_belt.ChartAreas[0].AxisY.Maximum = y_max + 1;
        }

        private void checkBox_show_belt_CheckedChanged(object sender, EventArgs e)
        {
            reloadChart();
            reloadListView();
        }

        private void checkBox_show_all_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_show_belt.Enabled = checkBox_show_all.Checked ? false : true;
            reloadChart();
            reloadListView();
        }

        private void chart_belt_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint dp = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                for (int j = 0; j < bd.buildings.Count(); j++)
                {
                    var bb = bd.buildings[j];
                    double offset1 = Math.Abs(bb.localOffset_x - dp.XValue);
                    double offset2 = Math.Abs(bb.localOffset_y - dp.YValues.First());
                    if (offset1 < 0.001 && offset2 < 0.001)
                    {
                        e.Text = string.Format("ID:{0}", j);
                        break;
                    }
                }
            }
        }
    }
}
