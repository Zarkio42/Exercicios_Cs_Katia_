using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx1
{
    internal class Ingresso
    {
        public double valor;
        public Ingresso(double valor)
        {
            this.valor = valor;
        }

        public string toString()
        {
            return $"Valor do ingresso = {this.valor.ToString("C")}";
        }
    }
}
