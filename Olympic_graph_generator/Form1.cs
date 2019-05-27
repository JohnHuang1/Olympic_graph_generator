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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a program which allows you to input data and draws a chart of your choice!", "What is this?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainFrm mainFrm = new mainFrm();
            mainFrm.Show();
            Hide();
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            btnStart.Select();
        }

    }
}
