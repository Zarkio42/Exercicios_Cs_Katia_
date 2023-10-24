using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaKatia_23_10_2023
{
    internal class Vendedor : Funcionario
    {
        public double ValorVenda { get; set; }

        public string MostrarDados(double valor)
        {
            return ($"Matricula: {Matricula} \nNome: {Nome}" +
                $"\nSalário: {Salario + valor * 0.1}");
        }
    }
}
