using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaKatia_23_10_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTotalVendas.Visible = false;
            txtTotal.Visible = false;
        }

        private void rbtnFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            rbtnVendedor.Checked = false;
            lblTotalVendas.Visible = false;
            txtTotal.Visible = false;

        }

        private void rbtnVendedor_CheckedChanged(object sender, EventArgs e)
        {
            rbtnFuncionario.Checked = false;
            lblTotalVendas.Visible = true;
            txtTotal.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rbtnFuncionario.Checked)
            {
                Funcionario f = new Funcionario();
                f.Nome = txtNome.Text;
                f.Matricula = Convert.ToInt32(txtMatricula.Text);
                f.Salario = Convert.ToDouble(txtSalario.Text);

                if (txtBonus.Text.Equals(""))
                {
                    MessageBox.Show(f.MostrarDados());
                }
                else
                {
                    MessageBox.Show(f.MostrarDados(Convert.ToDouble(txtBonus.Text)));
                }
            }
            if (rbtnVendedor.Checked)
            {
                Vendedor v = new Vendedor();
                v.Nome = txtNome.Text;
                v.Matricula = Convert.ToInt32(txtMatricula.Text);
                v.Salario = Convert.ToDouble(txtSalario.Text);

                MessageBox.Show(v.MostrarDados(Convert.ToDouble(txtTotal.Text)));
            }
        }

        
    }
}
