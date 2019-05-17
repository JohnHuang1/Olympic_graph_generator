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
            if(txt)
        }

    }
}
