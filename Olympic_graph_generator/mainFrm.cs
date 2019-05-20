using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_graph_generator
{
    public partial class mainFrm : Form
    {
        GraphDataModel graphData = new GraphDataModel();
        public mainFrm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string y = txtYaxis.Text;
            string x = txtXaxis.Text;
            lblTitle.Text = title;
            graphData.Title = title;
            lblXaxis.Text = x;
            graphData.Xaxis = x;
            lblYaxis.Text = y;
            graphData.Yaxis = y;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string name = txtItemName.Text;
            if(!name.Equals("") && Int64.TryParse(txtItemData.Text, out Int64 data))
            {
                if(btnAddItem.Text == "Add")
                {
                    graphData.AddItem(name, data);
                } else if (btnAddItem.Text == "Change")
                {
                    graphData.ChangeItemAt(lstData.SelectedIndex, name, data, 0);
                }
                ResetItemFields();
            } else
            {
                //TODO: Customize error message based on what is missing
                MessageBox.Show("Neither 'Name' nor 'Data' can be empty.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshListBox();
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            ResetItemFields();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ResetItemFields();
            ItemModel item = graphData.GetItemList()[lstData.SelectedIndex];
            graphData.RemoveItem(item);
            lstData.SetSelected(lstData.SelectedIndex + 1, true);
            RefreshListBox();
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemModel item = graphData.GetItemList()[lstData.SelectedIndex];
            txtItemName.Text = item.Name;
            txtItemData.Text = item.Data.ToString();

            btnAddItem.Text = "Change";
            btnDeleteItem.Visible = true;
            btnCancelItem.Visible = true;
        }

        public void RefreshListBox()
        {
            lstData.Items.Clear();
            foreach (ItemModel item in graphData.GetItemList())
            {
                lstData.Items.Add(item.Name + "\t\t" + item.Data);
            }
        }

        public void ResetItemFields()
        {
            txtItemName.Text = "";
            txtItemData.Text = "";
            btnAddItem.Text = "Add";
            btnDeleteItem.Visible = false;
            btnCancelItem.Visible = false;

        }

    }
}
