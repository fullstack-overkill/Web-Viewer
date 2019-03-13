using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Viwer
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmhelp_Load(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            btnSecret.Visible = true;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fullstack-overkill/Web-Viewer");
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você é incrivel !! You are awesome !! Eres increible !! Du er utroling !!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
