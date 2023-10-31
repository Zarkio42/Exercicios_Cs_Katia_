using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10_Katia_ClasseAbstrata_30_10_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlCirculo.Hide();
            pnlQuadrado.Hide();
            pnlRetangulo.Hide();
        }

        private void rbtnQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            pnlQuadrado.Show();
            pnlCirculo.Hide();
            pnlRetangulo.Hide();
        }

        private void rbtnCirculo_CheckedChanged(object sender, EventArgs e)
        {
            pnlQuadrado.Hide();
            pnlCirculo.Show();
            pnlRetangulo.Hide();
        }

        private void rbtnRetangulo_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlQuadrado.Hide();
            pnlCirculo.Hide();
            pnlRetangulo.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtnCirculo.Checked && !txtRaio.Text.Equals(""))
            {
                Circulo c = new Circulo();
                c.Raio = Convert.ToDouble(txtRaio.Text);
                lbArea.Text = "Área = "+ c.CalcularArea();
                lbPerimetro.Text = "Perímetro = " + c.CalcularPerimetro();
            }

            if (rbtnQuadrado.Checked && !txtLadoQuadrado.Text.Equals(""))
            {
                Quadrado q = new Quadrado();
                q.Lado = Convert.ToDouble(txtLadoQuadrado.Text);
                lbArea.Text = "Área = " + q.CalcularArea();
                lbPerimetro.Text = "Perímetro = " + q.CalcularPerimetro();
            }

            if (rbtnRetangulo.Checked && !txtLado1.Text.Equals("") && !txtLado2.Text.Equals(""))
            {
                Retangulo r = new Retangulo();
                r.Lado1 = Convert.ToDouble(txtLado1.Text);
                r.Lado2 = Convert.ToDouble(txtLado2.Text);
                lbArea.Text = "Área = " + r.CalcularArea();
                lbPerimetro.Text = "Perímetro = " + r.CalcularPerimetro();
            }

        }


    }
}
