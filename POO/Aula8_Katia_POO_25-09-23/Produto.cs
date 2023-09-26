using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Katia_POO_25_09_23
{
    internal class Produto
    {
        int produtoId;
        string produtoNome;
        double produtoPreco;

        public Produto (int produtoId, string produtoNome, double produtoPreco)
        {
            this.produtoId = produtoId;
            this.produtoNome = produtoNome;
            this.produtoPreco = produtoPreco;

        }

        public int getProdutoId() { return produtoId; }
        public string getProdutoNome() { return produtoNome; }
        public double getProdutoPreco() { return produtoPreco; }

        public void setProdutoId(int produtoId) { this.produtoId = produtoId; }
        public void setProdutoNome(string produtoNome) { this.produtoNome = produtoNome; }
        public void setProdutoPreco(double produtoPreco) { this.produtoPreco = produtoPreco; }

    }
}
