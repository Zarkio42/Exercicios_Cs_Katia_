using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8_Katia_POO_25_09_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Produto produto = new Produto(0, "", 0);
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            produto.setProdutoNome = txtNome.Text;
            double.TryParse(txtPreco.Text, out produto.setProdutoNome);

        }
    }
}
