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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
            txtEditor.RichTextBox.Text = "Hello World !";
              
        }
        
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
                if (!(Application.OpenForms.OfType<frmSobre>().Count() > 0))
                {
                    frmSobre.Show();
                }
                else
                {
                     Application.OpenForms[frmSobre.Name].Focus();
                }
        }

        private void btnVisualizarCodigo_Click(object sender, EventArgs e)
        {
            webVisualizar.DocumentText = txtEditor.RichTextBox.Text;
            this.tabAbas.SelectedTab = tabWEB;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEditor.RichTextBox.Text = " ";
            webVisualizar.DocumentText = txtEditor.RichTextBox.Text;

        }

        private void btnDividirEditorEmDois_Click(object sender, EventArgs e)
        {
            

        }


    }
}
