using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTurmaB2_Bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = txtNome.Text;
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            lblMensagem.ForeColor = Color.Blue;
        }
    }
}
