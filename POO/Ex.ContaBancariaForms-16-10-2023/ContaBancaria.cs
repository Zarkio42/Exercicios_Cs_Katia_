using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.ContaBancariaForms
{
    internal class ContaBancaria
    {
        public string Cliente { get; set; }
        public int num_conta { get; set; }
        public float saldo { get; set; }

        public float depositar(double v)
        {
            return $"Você depositou {v} \n Saldo atual: {saldo - depositar()}";
        }
    }
}
