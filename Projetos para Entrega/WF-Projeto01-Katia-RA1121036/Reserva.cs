using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto01_Katia_RA1121036
{
    internal class Reserva : Hospede
    {
        public double ValorTotalReserva { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public bool ReservaEfetivada { get; set; }
        public bool AtividadesExtra { get; set; }

        public override double Calcular()
        {
            return ValorTotalReserva;
        }
    }
}
