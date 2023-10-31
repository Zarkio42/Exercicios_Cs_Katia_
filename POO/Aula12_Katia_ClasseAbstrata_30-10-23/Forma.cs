using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Katia_ClasseAbstrata_30_10_23
{
    abstract class Forma
    {
        public string Name { get; set; }
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
