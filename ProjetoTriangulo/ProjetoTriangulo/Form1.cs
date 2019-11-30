using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            ladoA = int.Parse(txtLadoA.Text);
            ladoB = int.Parse(txtLadoB.Text);
            ladoC = int.Parse(txtLadoC.Text);

            if (ladoA + ladoB > ladoC && ladoB + ladoC > ladoA && ladoC + ladoA > ladoB)
            {
                if (ladoA == ladoB && ladoA == ladoC && ladoC == ladoB)
                {
                    lblResultado.Text = "O Triângulo é Equilatero.";
                    imgEquilatero.Visible = true;
                }
                else
                    if (ladoA == ladoB && ladoB != ladoC)
                {
                    lblResultado.Text = "O Triângulo é Isoceles.";
                    imgIsosceles.Visible = true;
                }

                else
                {
                    lblResultado.Text = "O Triângulo é Escaleno.";
                    imgEscaleno.Visible = true;
                }
              }

            else
            {
                lblResultado.Text = "Não forma um triângulo! :(";
                lblResultado.ForeColor = Color.Red;
            }
        }
    


        private void imgEquilatero_Click(object sender, EventArgs e)
        {

        }
    }
}
