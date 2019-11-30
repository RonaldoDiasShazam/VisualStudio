using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMusicaB
{
    public partial class FormMusicas : Form
    {
        public FormMusicas()
        {
            InitializeComponent();
            listarMusicas();
            escondePainel();
        }


        ModelMusica model = new ModelMusica();
        Musica musica;
        BindingSource bs;



        public void listarMusicas()
        {
            bs = new BindingSource();
            bs.DataSource = model.listarMusicas();
            DgvMusicas.DataSource = bs;
            // DgvMusicas.Columns[0].Visible = false;
        }



        public void escondePainel()
        {
            pnlInserir.Visible = false;
        }



        public bool ValidaConsulta()
        {
            if (txtBuscar.Text == String.Empty)
            {
                MessageBox.Show("Para efetuar a busca preencher o campo.",
                     "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscar.Focus();
                return false;
            }else{
                return true;
            }
        }




        // Metodo que valida os campos para inserção
        public bool ValidaCamposInserir()
        {
            if (txtAlbum.Text != string.Empty && txtArtista.Text !=
                string.Empty && txtNroFaixa.Text !=
                string.Empty && txtTitulo.Text != string.Empty &&
                cbGenero.Text != string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Paracadastrar musicas preencha todos" +
                    " os campos.", "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();
                return false;
            }
        }

        
        public void LimpaCampos()
        {
            txtAlbum.Text = string.Empty;
            txtArtista.Text = string.Empty;
            txtNroFaixa.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            cbGenero.Refresh();
        }



        public void InserirMusica()
        {
            musica = new Musica();
            musica.setArtista(txtArtista.Text);
            musica.setTitulo(txtTitulo.Text);
            musica.setGenero(int.Parse(cbGenero.SelectedValue.ToString()));
            musica.setAlbum(txtAlbum.Text);
            musica.setNroFaixa(int.Parse(txtNroFaixa.Text));

            if (model.addMusica(musica) > 0)
            {
                MessageBox.Show("musica Inserida Com Sucesso! ", "SUCESSO!",
                    MessageBoxButtons.OK);
                listarMusicas();
            }
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidaCamposInserir())
            {
                InserirMusica();
                LimpaCampos();
            }
        }

     

        // Botão Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            pnlInserir.Visible = false;
            if (ValidaCamposInserir())
            {
                Consultar();
            }
        }



public void Consultar()
        {
            string busca = txtBuscar.Text;

            BindingSource bs = new BindingSource();
            bs.DataSource = model.Consultar(busca);
            DgvMusicas.DataSource = bs;
            DgvMusicas.Columns[0].Visible = false;
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == string.Empty)
            {
                listarMusicas();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            pnlInserir.Visible = true;
        }
    }
}
