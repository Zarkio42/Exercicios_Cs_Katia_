using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Properties_Aula7
{
    public partial class Supermercado : Form
    {
        public Supermercado()
        {
            InitializeComponent();

            InsereProdutos();
            cbxProdutos.DataSource = produtosList;
        }

        List<Produto> produtosList = new List<Produto>();

        private void InsereProdutos()
        {
            Produto produto1 = new Produto()
            {
                Nome = "Banana",
                Preco = 5.00,
                EmEstoque = 100
            };
            produtosList.Add(produto1);
            Produto produto2 = new Produto()
            {
                Nome = "Maça",
                Preco = 3.00,
                EmEstoque = 100
            };
            produtosList.Add(produto2);
            Produto produto3 = new Produto()
            {
                Nome = "Tilapia",
                Preco = 15.00,
                EmEstoque = 100
            };
            produtosList.Add(produto3);
            Produto produto4 = new Produto()
            {
                Nome = "Bolo",
                Preco = 16.00,
                EmEstoque = 100
            };
            produtosList.Add(produto4);
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)cbxProdutos.SelectedItem;
                txtPreco.Text = produtoSelecionado.Preco.ToString("c");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)cbxProdutos.SelectedItem;
                listBoxSacola.Items.Add(produtoSelecionado.Nome + " - " + produtoSelecionado.Preco.ToString("C"));

                double somaTotal = 0;
                somaTotal += produtoSelecionado.Preco;
                txtTotal.Text = somaTotal.ToString("C");
                
            }

        }

    }
}
