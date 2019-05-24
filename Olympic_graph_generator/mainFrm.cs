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

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string name = txtItemName.Text;
            if(!name.Equals("") && int.TryParse(txtItemData.Text, out int data))
            {
                if(btnAddItem.Text == "Add")
                {
                    graphData.AddItem(name, data);
                } else if (btnAddItem.Text == "Change")
                {
                    graphData.ChangeItemAt(lstData.SelectedIndex, name, data, Color.Blue);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            graphFrm graphFrm = new graphFrm(graphData);
            graphFrm.Show();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ResetItemFields();
            ItemModel item = graphData.GetItemList()[lstData.SelectedIndex];
            graphData.RemoveItem(item);
            lstData.SetSelected(lstData.SelectedIndex + 1, true);
            RefreshListBox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GraphDataModel testData = new GraphDataModel("Pullups", "# of Pullups in a Row", "People");
            testData.AddItem("Forest", 23);
            testData.AddItem("John", 10);
            testData.AddItem("Raheel", 19);
            testData.AddItem("Tyler", 13);
            testData.AddItem("Rami", 15);
            graphData = testData;
            UpdateForm(1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            graphData.Title = txtTitle.Text;
            graphData.Yaxis = txtYaxis.Text;
            graphData.Xaxis = txtXaxis.Text;

            UpdateForm(0);
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

        private void UpdateForm(int updateValue)
        {
            if(updateValue >= 0)
            {
                lblTitle.Text = graphData.Title;
                txtTitle.Text = graphData.Title;
                lblYaxis.Text = graphData.Yaxis;
                txtYaxis.Text = graphData.Yaxis;
                lblXaxis.Text = graphData.Xaxis;
                txtXaxis.Text = graphData.Xaxis;

                ResetItemFields();
                if(updateValue >= 1)
                {
                    RefreshListBox();
                } 
            }
        }

    }
}
