using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    interface IConta
    {
        void Sacar(double valor);
        double CalculaTributo();
    }
}
