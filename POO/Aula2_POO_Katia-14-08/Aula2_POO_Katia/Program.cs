using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Classes_Katia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] todos = new Funcionario[3];

            for (int i = 0; i < todos.Length; i++)
            {

                //instanciação do objeto
                Funcionario alguem = new Funcionario();
                Console.WriteLine("Informe o nome");
                alguem.setNome(Console.ReadLine());
                Console.WriteLine("Informe o cargo");
                alguem.setCargo(Console.ReadLine());
                Console.WriteLine("Informe o salario");
                alguem.setSalario(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Informe a data de nascimento");
                alguem.setNascimento(Convert.ToDateTime(Console.ReadLine()));
                todos[i] = alguem;

                Console.Clear();
            }

            //exibe todos os objetos do vetor
            for (int x = 0; x < todos.Length; x++)
            {
                Console.WriteLine($"Funcionário: {todos[x].getNome()}" + $"\nCargo: {todos[x].getCargo()} \nSalário: {todos[x].getSalario()}" +
                    $"\nData de Nascimento: {todos[x].getNascimento()} \nIdade: {todos[x].calculaIdade()} anos");
                Console.Beep();//apenas um beep
            }

            //busca um funcionario pelo nome

            Console.WriteLine("Informe o nome do funcionario");
            string busca = Console.ReadLine();
            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i].getNome().Equals(busca))
                {
                    Console.WriteLine($"Funcionário: {todos[i].getNome()}" + $"\nCargo: {todos[i].getCargo()} \nSalário: {todos[i].getSalario()}" +
                   $"\nData de Nascimento: {todos[i].getNascimento()} \nIdade: {todos[i].calculaIdade()} anos");
                }
            }

            Console.ReadKey();
        }
    }
}
