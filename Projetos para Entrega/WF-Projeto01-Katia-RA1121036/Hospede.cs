using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto01_Katia_RA1121036
{
    abstract class Hospede
    {
        string Nome { get; set; }
        int Cpf { get; set; }
        int Telefone { get; set; }

        public abstract double Calcular();

    }
}
