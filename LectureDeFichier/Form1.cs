using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LectureDeFichier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdReadFile_Click(object sender, EventArgs e)
        {
            string result = "";
            StreamReader file = new StreamReader(txtFile.Text);
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                result += line;
                result += Environment.NewLine;
            }
            txtcontenu.Text = result;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
