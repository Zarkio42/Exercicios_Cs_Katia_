using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Projeto01_Katia_RA1121036
{
    internal class Reserva : Hospede
    {
        public string QuartoReservado { get; set; }
        public double ValorTotalReserva { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public bool PagamentoPendente { get; set; }

        public override double Calcular(double x)
        {
            return ValorTotalReserva += x;
        }
    }
}
