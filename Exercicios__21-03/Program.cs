using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_exemplos_Katia_21_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numeros Pares e Ímpares!
            //-------------------------------------------------------

            /*
            int result, num;
            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num);
            result = num % 2;
            if (result == 0) {
                Console.WriteLine("É Par!");
            }
            else
            {
                Console.WriteLine("É Impar!");
            }
            Console.ReadKey();
            */

            //------------------------------------------------------------
            // Exemplo: Receber 3 valores e ordena-los em ordem crescente!
            //------------------------------------------------------------

            /*
            int v1, v2, v3;
            Console.WriteLine("Digite o primeiro valor: " + "\n");
            int.TryParse(Console.ReadLine(), out v1);
            Console.WriteLine("Digite o segundo valor: " + "\n");
            int.TryParse(Console.ReadLine(),out v2);
            Console.WriteLine("Digite o terceiro valor: " + "\n");
            int.TryParse(Console.ReadLine(), out v3 );
            if (v1 > v2 && v2 > v3)
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v3 + ", " + v2 + ", " + v1);
            }
            else if (v1 > v3 && v3 > v2)
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v2 + ", " + v3 + ", " + v1);
            }
            else if (v2 > v1 && v1 > v3) 
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v3 + ", " + v1 + ", " + v2);
            }
            else if (v2 > v3 && v3 > v1)
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v1 + ", " + v3 + ", " + v2);
            }
            else if (v3 > v2 && v2 > v1)
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v1 + ", " + v2 + ", " + v3);
            }
            else if (v3 > v1 && v1 > v2)
            {
                Console.WriteLine($"Organizado em ordem crescente: " + v2 + ", " + v1 + ", " + v3);
            }
            Console.ReadKey();
            */

            //------------------------------------------------------------------------------------------------------------------------------------------
            // Fazer um programa que recebe o preço de um produto e mostra o seu desconto. Se o produto custar até 200RS --> 10% desconto. Acima, 12,5%.
            //------------------------------------------------------------------------------------------------------------------------------------------

            /*
            double preco, desc;
            Console.WriteLine("Digite o preço do produto: " + "\n");
            double.TryParse(Console.ReadLine(), out preco);
            if (preco <= 200)
            {
                desc = preco * 0.9;
                Console.WriteLine("Você recebeu um desconto de 10%!" + "\n" + "Total a pagar: " + desc);
            }
            else
            {
                desc = preco * 0.875;
                Console.WriteLine("Você recebeu um desconto de 12.5%" + "\n" + "Total a pagar: " + desc);
            }
            Console.ReadKey();
            */

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Fazer um programa que recebe o cargo e o valor do salário e mostre o valor do INSS. Considere a aliquota de 10% para salário até 3000 reais e a aliquota de 14%
            //para valores maiores que 3000 reais.
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------

            string cargo;
            double salario, aliq;

            Console.WriteLine("Digite o cargo que você ocupa atualmente:" + "\n");
            cargo = Console.ReadLine();

            Console.WriteLine("Digite o seu salário atual: " + "\n");
            double.TryParse(Console.ReadLine(), out salario);

            if (salario <= 3000)
            {
                aliq = salario * 0.1;
                Console.WriteLine("O valor do INSS é de: " + aliq + "R$");
            }

            else
            {
                aliq = salario * 0.14;
                Console.WriteLine("O valor do INSS é de: " + aliq + "R$");
            }
            Console.ReadKey();

            //...
        }
    }
}
