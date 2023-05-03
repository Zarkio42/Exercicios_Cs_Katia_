using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_KATIA_02_05_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de fatorial com FOR
            //----------------------------

            /*

            int fat = 0, num, i = 0;

            Console.WriteLine("Digite o numero que você deseja: ");
            int.TryParse(Console.ReadLine(), out num);

            Console.Clear();

            fat = num; 
            for (i = num - 1; i > 0; i--)
            {
                fat = fat * i;               
            }

            Console.WriteLine(fat);

            Console.Read();
            */

            //-----------------------------
            //Fazer um programa que recebe médias de alunos e mostra a média da turma. Quando for informado
            //-1, o programa deverá mostrar a média da turma.
            //-----------------------------

            /*
            int[] mediaTurma = new int[4];
            var countAluno = 1;
            int i = 0, verMedia;
            var calcMedia = 0;

            do
            {
                Console.WriteLine($"Digite a média do aluno {countAluno}: ");
                int.TryParse(Console.ReadLine(), out mediaTurma[i]);
                countAluno++;
                i++;

            } while (countAluno <= 4);

            Console.WriteLine("Para verificar a média da turma, digite -1! \n");
            int.TryParse(Console.ReadLine(), out verMedia);

            if (verMedia == -1)
            {
                for (int j = 0; j < mediaTurma.Length; j++)
                {
                    calcMedia += mediaTurma[j];
                }
                Console.WriteLine(calcMedia/mediaTurma.Length);
            }      

            Console.Read();
            

            //-----------------------
            //Outro método sem vetor
            //-----------------------

            int alunoCount = 1, valor, media = 0, jcount = 0;
            bool rep = true;
            
            while (rep) 
            {
                Console.WriteLine($"Digite a nota do aluno {alunoCount}");
                int.TryParse(Console.ReadLine(), out valor);

                if (valor == -1)
                {

                    Console.WriteLine($"A média da turma é: {media / jcount}");
                    rep = false;
                }
                jcount++;
                alunoCount++;
                media += valor;
                
            }
            Console.ReadKey();
            
             */

            //---------------------------------
            //Metodo com vetor usando while.
            //---------------------------------

            int[] mediaTurma = new int[100];
            var countAluno = 1;
            int i = 0, div = 0, calcMedia = 0;
            bool pass = true;

            while (pass)
            {
                Console.WriteLine($"Digite a média do aluno {countAluno}: ");
                int.TryParse(Console.ReadLine(), out mediaTurma[i]);

                if (mediaTurma[i] == -1)
                {
                    pass = false;

                    for (int j = 0; j < div; j++)
                    {
                        calcMedia += mediaTurma[j];
                    }
                    Console.WriteLine($"A média da turma é: {calcMedia / div}");
                }
                div++;
                countAluno++;
                i++;
            }

            Console.Read();

        }
    }
}
