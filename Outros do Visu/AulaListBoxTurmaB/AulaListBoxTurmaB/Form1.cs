using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaListBoxTurmaB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEsq_Click(object sender, EventArgs e)
        {
            lboEsquerda.Items.Add(txtEsquerda.Text);
            txtEsquerda.Text = "";
        }

        private void btnAdicionarDir_Click(object sender, EventArgs e)
        {
            lboDireita.Items.Add(txtDireita.Text);
            txtDireita.Text = "";
        }

        private void btnRemoverEsq_Click(object sender, EventArgs e)
        {
            lboEsquerda.Items.Remove(lboEsquerda.SelectedItem);
        }

        private void btnRemoverDir_Click(object sender, EventArgs e)
        {
            lboDireita.Items.Remove(lboDireita.SelectedItem);
        }

        private void btnEnviarDir_Click(object sender, EventArgs e)
        {
            if(lboEsquerda.SelectedItem != null)

                lboDireita.Items.Add(lboEsquerda.SelectedItem);
                lboEsquerda.Items.Remove(lboEsquerda.SelectedItem);
            
        }

        private void btnEnviarEsq_Click(object sender, EventArgs e)
        {
            if (lboDireita.SelectedItem != null)

                lboEsquerda.Items.Add(lboDireita.SelectedItem);
                lboDireita.Items.Remove(lboDireita.SelectedItem);
        }

        private void txtEsquerda_TextChanged(object sender, EventArgs e)
        {

        }

        private void lboEsquerda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
