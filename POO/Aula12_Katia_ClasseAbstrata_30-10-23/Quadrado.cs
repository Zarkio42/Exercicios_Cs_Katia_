using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Katia_ClasseAbstrata_30_10_23
{
    internal class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
