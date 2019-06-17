using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ballon
{
    public partial class frmBallon : Form
    
    {
        int tick=0;
        public frmBallon()
        {
            InitializeComponent();
            
        }

        private void frmBallon_Load(object sender, EventArgs e)
        {

        }

        private void tmrTicTac_Tick(object sender, EventArgs e)
        {
            tick++;
            label1.Text = tick.ToString();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            /*comment faire stop et start*/
             
            tmrTicTac.Enabled = true;
            label1.Text = tick.ToString();
            cmdStart.Text= "stop";
         

    
        }
    }
}
