using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Cs_Katia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que pergunta a medida da frente e do lado. Em seguida calcula a area e o perímetro!
            //--------------------------------------------------------------------------------------------

            /*
            * minha solução
           int frente = 5 ;
           int lado = 10;
           Console.WriteLine("Perimetro = " + frente*2+lado*2);
           Console.WriteLine("Área= " + frente*lado);
           Console.ReadKey();
           */

            /* SOLUÇÃO DA PROFESSORA*/
            /*
                    double lado, frente, area, perimetro;
                    Console.WriteLine("Informe a metragem" + " da frente");
                    frente = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a metragem" + " do lado");
                    lado = Convert.ToDouble(Console.ReadLine());
                    area = lado * frente;
                    perimetro = lado * 2 + frente * 2;
                    Console.WriteLine("Sua area é = " + area);
                    Console.WriteLine("Seu perimetro é = " + perimetro);
                    Console.ReadKey();
            */

            /*Minha solução 2 (teste converter int32)
                       int frente;
                       int lado;
                       Console.Write("INSIRA O VALOR FRENTE = ");
                       frente = Convert.ToInt32(Console.ReadLine());
                       Console.Write("INSIRA O VALOR LADO = ");
                       lado = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("SUA ÁREA É DE = " + lado*frente);
                       Console.WriteLine("SEU PERÍMETRO É DE = " + (lado+lado+frente+frente));
                       Console.ReadKey();
            */

            //---------------------------------------------------------
            //1) Fazer um programa que recebe 2 notas e mostre a média.
            //---------------------------------------------------------

            /*
            double nota1, nota2;
            Console.WriteLine("Insira a primeira nota = ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota = ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sua média é: " + ((nota1 + nota2) /2));
            Console.ReadKey();  
            */

            //-----------------------------------------------------------------------------------------------------------
            //2) Fazer um Programa que recebe o valor de um produto e mostre o valor a pagar. considere o desconto de 5%.
            //-----------------------------------------------------------------------------------------------------------

            /* 
            double valor;
            Console.WriteLine("Insira seu valor = ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor a ser pago = " + (valor-(0.05*valor)));
            Console.ReadKey();
            */

            //-------------------------------------------------------------------------------------------
            // 3) FAzer um Programa que mostre o valor a pagar da castanha, sabe-se que o valor do quilo
            // da castanha é 65 reais e o programa recebe o peso em gramas
            //-------------------------------------------------------------------------------------------

            /*
            double castanhakg;
            Console.WriteLine("Quantos gramas de castanha você quer?");
            castanhakg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor a ser pago = " + castanhakg * 0.065);
            Console.ReadKey();
            */

            //Mais um exemplo do mesmo exercício --

            /*
            double castanhakg;
            Console.WriteLine("Quantos gramas de castanha você quer?");
            double.TryParse(Console.ReadLine(), out castanhakg);
            Console.WriteLine("Valor a ser pago = " + castanhakg * 0.065);
            Console.ReadKey();
            */

            //--------------------------------------------------------------------------------------------
            //Exercício 4 - Fazer um programa que recebe o nome, cargo e salário atual de um funcionário.
            //Mostre o salário reajustado, considere 9,5% de reajuste.
            //-------------------------------------------------------------------------------------------

            /*
            		double salario;
            string nome, cargo;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu cargo atual");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite seu salário");
            double.TryParse(Console.ReadLine(), out salario);
            Console.WriteLine("Seu salário foi reajustado para: " + (salario + (salario * 0.095)));
            Console.ReadKey();
            */

            //--------------------------------------------------------------------------------------------------------
            //Exercício 5 - Fazer um programa que recebe o total de faltas de um aluno e o total de aulas
            //dadas da disciplina de Fundamentos e Técnicas de programação. Mostre o percentual de faltas desse aluno.
            //--------------------------------------------------------------------------------------------------------

            double faltas, aulas;

            Console.WriteLine("Digite o total de aulas");
            double.TryParse(Console.ReadLine(), out aulas);

            Console.WriteLine("Digite o total de faltas");
            double.TryParse(Console.ReadLine(), out faltas);

            Console.WriteLine("Você faltou em " + (faltas / aulas) * 100 + "% das aulas! :(");

            Console.ReadKey();

        }
    }
}
