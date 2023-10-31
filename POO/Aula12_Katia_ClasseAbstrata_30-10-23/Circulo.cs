using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Katia_ClasseAbstrata_30_10_23
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }
        public double pi = 3.14;

        public override double CalcularArea()
        {
            return (pi * Raio * Raio);
        }
        public override double CalcularPerimetro()
        {
            return (2 * pi * Raio);
        }
    }
}
