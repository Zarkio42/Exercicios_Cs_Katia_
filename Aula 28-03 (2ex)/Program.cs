using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Katia_28_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------------------------------
            //Fazer um programa que recebe o tipo do combustível de um carro, a distância percorrida e mostre a quantidade de combustível
            // consumida. considere a autonomia segundo o tipo de combustivel: Gasolina: 10km/l -- Alcool: 8.5km/l -- Etanol: 7.5km/l
            //----------------------------------------------------------------------------------------------------------------------------
            /*
            string tipo = "Gasolina (1) - Álcool (2) - Etanol (3)";
            double km;

            Console.WriteLine("Insira qual tipo de combustível você utiliza: " + tipo + "\n");
            tipo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Digite a distância percorrida pelo seu veículo em metros: \n");
            double.TryParse(Console.ReadLine(), out km);

            Console.Clear();

            if (tipo == "1")
            {
                Console.WriteLine("Você consumiu: " + (km / 1000) / 10 + "L");
                Console.WriteLine("\n  -           __\r\n --          ~( @\\   \\\r\n---   _________]_[__/_>________\r\n     /  ____ \\ <>     |  ____  \\\r\n    =\\_/ __ \\_\\_______|_/ __ \\__D\r\n________(__)_____________(__)____");
            }

            else if (tipo == "2")
            {
                Console.WriteLine("Você consumiu: " + (km / 1000) / 8.5 + "L");
                Console.WriteLine("\n  -           __\r\n --          ~( @\\   \\\r\n---   _________]_[__/_>________\r\n     /  ____ \\ <>     |  ____  \\\r\n    =\\_/ __ \\_\\_______|_/ __ \\__D\r\n________(__)_____________(__)____");
            }

            else
            {
                Console.WriteLine("Você consumiu: " + (km / 1000) / 7.5 + "L");
                Console.WriteLine("\n  -           __\r\n --          ~( @\\   \\\r\n---   _________]_[__/_>________\r\n     /  ____ \\ <>     |  ____  \\\r\n    =\\_/ __ \\_\\_______|_/ __ \\__D\r\n________(__)_____________(__)____");
            }
            
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------------------------------------------------------------------
            //Fazer um programa que recebe um número de 4 dígitos e mostre se o número é mágico. Separa-se os dois primeiros dígitos dos dois últimos, soma-se
            // e o resultado eleve a 2. Exemplo: 3025, separa-se 30 e 25 resultará em 55. 55*55 = 3025.
            //-------------------------------------------------------------------------------------------------------------------------------------------------

            int n1, m, mm, soma;

            do
            {
                Console.WriteLine("Digite um número de 4 dígitos");
                int.TryParse(Console.ReadLine(), out n1);
                Console.Clear();
            } while (n1 < 1000);

            m = n1 / 100;
            mm = n1 % 100;

            soma = m + mm;

            if (soma * soma == n1)
            {
                Console.Clear();
                Console.WriteLine(soma * soma + "\n");
                Console.WriteLine("O número " + n1 + " é mágico!");

            }

            else
            {
                Console.WriteLine("O número " + n1 + " não é mágico!");
            }

            Console.ReadKey();








        }
    }
}
