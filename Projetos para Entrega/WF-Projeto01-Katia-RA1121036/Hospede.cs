using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto01_Katia_RA1121036
{
    abstract class Hospede
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Telefone { get; set; }

        public abstract double Calcular(double x);

    }
}
