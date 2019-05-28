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
                    graphData.AddItem(name, data, lblColorBox.BackColor);
                } else if (btnAddItem.Text == "Change")
                {
                    graphData.ChangeItemAt(lstData.SelectedIndex, name, data, lblColorBox.BackColor);
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
            if(graphData.GetItemList().Count > 0)
            {
                graphData.gType = CheckRadioButton();
                graphFrm graphFrm = new graphFrm(graphData);
                graphFrm.Show();
            }
            else
            {
                MessageBox.Show("There is no data to draw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                lblColorBox.BackColor = colorPicker.Color;
                lblColorName.Text = colorPicker.Color.Name;
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ResetItemFields();
            ItemModel item = graphData.GetItemList()[lstData.SelectedIndex];
            graphData.RemoveItem(item);
            RefreshListBox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GraphDataModel testData = new GraphDataModel("Ethnic Groups in Nepal", "Percentage", "Ethnic Group");

            testData.AddItem("Chhetteri", 16.6);
            testData.AddItem("Brahman - Hill", 16.6);
            testData.AddItem("Magar", 7.1);
            testData.AddItem("Tharu", 6.6);
            testData.AddItem("Tamang", 5.8);
            testData.AddItem("Newar", 5);
            testData.AddItem("Kami", 4.8);
            testData.AddItem("Muslim", 4.4);
            testData.AddItem("Yadav", 4);
            testData.AddItem("Rai", 2.3);
            testData.AddItem("Gurung", 2);
            testData.AddItem("Damai / Dholii", 1.8);
            testData.AddItem("Thakuri", 1.6);
            testData.AddItem("Limbu", 1.5);
            testData.AddItem("Sarki", 1.4);
            testData.AddItem("Teli", 1.4);
            testData.AddItem("Chamar / Harijan / Ram", 1.3);
            testData.AddItem("Kooiri / Kushwaha", 1.2);
            testData.AddItem("Other", 19);

            Random rnd = new Random();
            List<ItemModel> items = testData.GetItemList();
            foreach(ItemModel item in items)
            {
                testData.ChangeItemAt(items.IndexOf(item), item.Name, item.Data, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            }
            testData.gType = 0;
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

        private GraphDataModel.GraphType CheckRadioButton()
        {
            GraphDataModel.GraphType result = 0;
            switch (grpGraphChoices.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name)
            {
                case "radBar":
                    result = GraphDataModel.GraphType.BarGraph;
                    break;
                case "radPie":
                    result = GraphDataModel.GraphType.PieChart;
                    break;
                case "radLine":
                    result = GraphDataModel.GraphType.LineGraph;
                    break;
            }
            return result;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ItemModel item = graphData.GetItemList()[lstData.SelectedIndex];
                txtItemName.Text = item.Name;
                txtItemData.Text = item.Data.ToString();
                lblColorBox.BackColor = item.Color;
                lblColorName.Text = item.Color.Name;

                btnAddItem.Text = "Change";
                btnDeleteItem.Visible = true;
                btnCancelItem.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshListBox()
        {
            lstData.Items.Clear();
            foreach (ItemModel item in graphData.GetItemList())
            {
                lstData.Items.Add(item.Name + "\t\t" + item.Data + "\t\t" + item.Color.Name);
            }
        }

        public void ResetItemFields()
        {
            txtItemName.Text = "";
            txtItemData.Text = "";
            btnAddItem.Text = "Add";
            lblColorBox.BackColor = Color.Black;
            lblColorName.Text = "Default: Black";
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
                    switch (graphData.gType)
                    {
                        case GraphDataModel.GraphType.PieChart:
                            radPie.Select();
                            break;
                        case GraphDataModel.GraphType.BarGraph:
                            radBar.Select();
                            break;
                        case GraphDataModel.GraphType.LineGraph:
                            radLine.Select();
                            break;
                    }
                } 
            }
        }
    }
}
