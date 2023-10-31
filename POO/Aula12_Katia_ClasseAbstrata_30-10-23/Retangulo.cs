using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10_Katia_ClasseAbstrata_30_10_23
{
    internal class Retangulo : Forma
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public override double CalcularArea()
        {
            return (Lado1 * Lado2);
        }

        public override double CalcularPerimetro()
        {
            return ((Lado1 * 2) + (Lado2 * 2));
        }
    }
}
