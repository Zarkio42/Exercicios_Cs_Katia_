using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Properties_Aula7
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int EmEstoque {  get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
