using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            Conta conta = new Conta();

            Console.WriteLine("\t--- Bem Vindo ao Banco Mundial! ---\n");
            Console.WriteLine("Digite seu nome: ");
            conta.setNome(Console.ReadLine());
            Console.WriteLine("Digite seu cpf: ");
            conta.setCpf(Console.ReadLine());
            conta.setSaldo(0);
            Console.Clear();

            Console.WriteLine("O que deseja fazer?\n (1) DEPOSITO\n (2) SAQUE\n (3) MEU SALDO\n (4) SAIR");
            int.TryParse(Console.ReadLine(), out resposta);
            Console.Clear();
            do
            {
                if (resposta == 1)
                {
                    Console.WriteLine("Digite a quantia a ser depositada: ");
                    conta.opDepositar(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine($"Seu saldo atual é de {conta.getSaldo()}");
                    Console.WriteLine("\n(1) Para efetuar um deposito;\n(2) Para efetuar um saque;\n(3) Para ver seu saldo;\n(4) Para sair;");
                    int.TryParse(Console.ReadLine(), out resposta);
                    Console.Clear();
                }
                else if (resposta == 2)
                {
                    double valorSaque;
                    Console.WriteLine("Digite a quantia a ser sacada: ");
                    double.TryParse(Console.ReadLine(), out valorSaque);
                    Console.Clear();

                    if (valorSaque > conta.getSaldo())
                    {
                        Console.WriteLine("Saldo insuficiente para realizar um saque!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        conta.opSaque(valorSaque);
                        Console.WriteLine("Saque efetuado com sucesso!");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    Console.Clear();
                    Console.WriteLine($"Seu saldo atual é de {conta.getSaldo()}");
                    Console.WriteLine("\n(1) Para efetuar um deposito;\n(2) Para efetuar um saque;\n(3) Para ver seu saldo;\n(4) Para sair;");
                    int.TryParse(Console.ReadLine(), out resposta);
                    Console.Clear();
                }
                else if (resposta == 3)
                {
                    Console.WriteLine($"Seu saldo atual é de {conta.getSaldo()}");
                    Console.WriteLine("\n(1) Para efetuar um deposito;\n(2) Para efetuar um saque;\n(3) Para ver seu saldo;\n(4) Para sair;");
                    int.TryParse(Console.ReadLine(), out resposta);
                }

            } while (resposta != 4);

            Console.WriteLine("Obrigado, até a próxima!");
            Console.ReadKey();


        }
    }
}
