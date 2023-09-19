using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Katia_18_09_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Produto produto = new Produto();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            produto.Nome = txtNome.Text;
            produto.preco = Convert.ToDouble(txtPreco.Text);
            MessageBox.Show(produto.Nome + "\nPreço: " + produto.preco.ToString("C") + "\nValor a pagar: " + (produto.preco
                * Convert.ToInt32(txtQuantidade.Text)).ToString("C"));
        }
    }
}
