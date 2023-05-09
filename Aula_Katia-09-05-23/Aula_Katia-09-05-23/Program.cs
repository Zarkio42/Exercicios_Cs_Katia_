using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Katia_09_05_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercícios da Katia sobre adicionar dados em um vetor e resgatar eles!
            //----------------------------------------------------------------------
            Console.WriteLine("Quantas notas você deseja registrar?");
            int.TryParse(Console.ReadLine(), out int quantidadeNotas);

            double[] nota = new double[quantidadeNotas];
            int i, aluno = 0;
            double soma = 0;
            //atribui elementos digitados pelo usuário no vetor

            for (i = 0; i < quantidadeNotas; i++)
            {               
                Console.WriteLine("Informe a nota: ");
                nota[i] = Convert.ToDouble(Console.ReadLine());
                soma += nota[i];
                Console.Clear();
            }

            for (i = 0; i < quantidadeNotas; i++)
            {
                aluno++;
                Console.WriteLine($"A nota do aluno {aluno} é {nota[i]}");
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Média de todas as notas: {soma/nota.Length}");

            Console.ReadKey();
        }
    }
}
