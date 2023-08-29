using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Aula4_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato[] agenda = new Contato[10];
            Contato pessoa;
            int op, cont = 0;

            do
            {
                Console.WriteLine("Qual opção deseja?\n ");
                Console.WriteLine("1 - Adicionar contato\n2- Procurar um contato\n3- Mostrar todos os contatos");
                int.TryParse(Console.ReadLine(), out op);

                switch (op)
                {
                    case 1:
                        pessoa = new Contato();
                        Console.WriteLine("Informe o nome: ");
                        pessoa.setNome(Console.ReadLine());
                        Console.WriteLine("Idade: ");
                        pessoa.setIdade(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Número: ");
                        pessoa.setNumero(Convert.ToInt32(Console.ReadLine()));
                        agenda[cont] = pessoa;
                        cont++;
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Informe o nome: ");
                        string name = Console.ReadLine();
                        for (int i = 0; i < cont; i++)
                        {
                            if (agenda[i].getNome().Equals(name))
                            {
                                Console.WriteLine($"Nome: {agenda[i].getNome()}" +
                                    $"\nIdade: {agenda[i].getIdade()}" +
                                    $"\nNúmero: {agenda[i].getNumero()}");
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        for (int i = 0; i < cont; i++)
                        {
                            Console.WriteLine($"Nome: {agenda[i].getNome()}" +
                                    $"\nIdade: {agenda[i].getIdade()}" +
                                    $"\nNúmero: {agenda[i].getNumero()}\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Digite 0 para sair ou qualquer outro para ficar!\n");

            } while (op != 0);

        }
    }
}
