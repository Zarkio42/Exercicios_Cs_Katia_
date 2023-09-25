using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                Preco = 5.5
            };
            produtosList.Add(produto1);
            Produto produto2 = new Produto()
            {
                Nome = "Maça",
                Preco = 3
            };
            produtosList.Add(produto2);
            Produto produto3 = new Produto()
            {
                Nome = "Tilapia",
                Preco = 15
            };
            produtosList.Add(produto3);
            Produto produto4 = new Produto()
            {
                Nome = "Bolo",
                Preco = 16
            };
            produtosList.Add(produto4);
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)cbxProdutos.SelectedValue;
                txtPreco.Text = produtoSelecionado.Preco.ToString("c");
                numericAmount.Value = 1;
            }
        }

        int valueChange = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)cbxProdutos.SelectedItem;
                Produto produtoSelecionadoValor = (Produto)cbxProdutos.SelectedValue;
                bool jaExiste = false;
                double totalSacola = 0;

                for (int i = 0; i < listBoxSacola.Items.Count; i++)
                {
                    if (listBoxSacola.Items[i].ToString().Contains(produtoSelecionado.Nome))
                    {
                        jaExiste = true;
                        break;
                    }
                }

                if (jaExiste)
                {
                    for (int i = 0; i < listBoxSacola.Items.Count; i++)
                    {
                        if (listBoxSacola.Items[i].ToString().Contains(produtoSelecionado.Nome))
                        {
                            int quantidadeAtual = Convert.ToInt32(listBoxSacola.Items[i + 2]);
                            quantidadeAtual += valueChange;
                            listBoxSacola.Items[i + 2] = quantidadeAtual.ToString();
                        }
                    }
                }
                else
                {
                    listBoxSacola.Items.Add($"{produtoSelecionado.Nome}");
                    listBoxSacola.Items.Add($"{produtoSelecionadoValor.Preco.ToString("C")}");
                    listBoxSacola.Items.Add($"{valueChange}");
                    //listBoxSacola.Margin = new System.Windows.Forms.Padding();
                }

                totalSacola = CalcularTotal();
                txtTotal.Text = totalSacola.ToString("c");



            }
        }

        private double CalcularTotal()
        {
            double total = 0;

            for (int i = 0; i < listBoxSacola.Items.Count; i += 3)
            {
                string precoItem = listBoxSacola.Items[i + 1].ToString();
                double.TryParse(precoItem, out double preco);

                string quantidadeItem = listBoxSacola.Items[i + 2].ToString();
                int.TryParse(quantidadeItem, out int quantidade);

                total += quantidade * preco;

            }

            return total;
        }

        private void numericAmount_ValueChanged(object sender, EventArgs e)
        {
            valueChange = Convert.ToInt32(numericAmount.Value);
        }
    }
}

