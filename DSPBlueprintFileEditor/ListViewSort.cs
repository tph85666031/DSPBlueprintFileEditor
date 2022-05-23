using System;
using System.Collections;
using System.Windows.Forms;

namespace DSPBlueprintFileEditor
{
    public class ListViewSort : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewSort()
        {
            col = 0;
        }
        public ListViewSort(int column, SortOrder order)
        {
            this.order = order;
            col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递
        }
        public int Compare(object x, object y)
        {
            if (col == 0 || col == 1 || col == 4 || col == 5 || col == 6 || col == 7)
            {
                float value_x = float.Parse(((ListViewItem)x).SubItems[col].Text);
                float value_y = float.Parse(((ListViewItem)y).SubItems[col].Text);
                if (order == SortOrder.Descending)
                {
                    return (int)((value_x - value_y) * 1000000);
                }
                else
                {
                    return (int)((value_y - value_x) * 1000000);
                }
            }
            else
            {
                int result = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                if (order == SortOrder.Descending)
                {
                    return -result;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}
