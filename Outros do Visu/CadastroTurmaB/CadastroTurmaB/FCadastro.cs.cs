using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroTurmaB
{
    public partial class FCadastro : Form
    {
        public FCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            comboBox1.SelectedIndex = -1;
            txtEmail.Text = "";
            maskFone.Text = "";
            maskData.Text = "";
            rdbCasado.Checked = false;
            rdbSolteiro.Checked = false;
            rdbOutro.Checked = false;
        }

        private void btnComfirmar_Click(object sender, EventArgs e)
        {
           lblResultado.Text = "Parabéns " + txtNome.Text + " , seu cadastro foi efetuado com \n"+
           "sucesso. Entraremos em contato pelo E-mail: \n" + txtEmail.Text +
           "ou pelo Telefone:" + maskFone.Text ;
        }
    }
}
