using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx1
{
    internal class IngressoVip : Ingresso
    {
        double adicional;
        public IngressoVip(double v, double a) : base(v)
        {
            this.adicional = a;
        }

        public string calcular()
        {
            return $"Valor a pagar: {(this.adicional + valor).ToString("C")}";
        }
    }
}
