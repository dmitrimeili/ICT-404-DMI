using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenue
{
    public partial class frmBienvenue : Form
    {
        public frmBienvenue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBienvenue_Load(object sender, EventArgs e)
        {
            lblBienvenueDate.Text = string.Format("{0:dd MMM yyyy}", DateTime.Now);
        }
    }
}
