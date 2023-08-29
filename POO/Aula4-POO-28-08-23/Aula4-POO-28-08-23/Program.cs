using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_POO_28_08_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador player = new Jogador();

            Console.WriteLine("Informe o nome do jogador: ");
            player.setNome(Console.ReadLine());
            Console.WriteLine("Informe a posição em que ele joga:");
            player.setPosicao(Console.ReadLine());
            Console.WriteLine("Informe a nacionalidade do jogador: ");
            player.setNacionalidade(Console.ReadLine());
            Console.WriteLine("Informe a altura do jogador: ");
            player.setAltura(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe o peso do jogador: ");
            player.setPeso(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a data de nascimento: ");
            player.setNascimento(Convert.ToDateTime(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine("\nInformações do Jogador:\n");
            Console.WriteLine($"Jogador: {player.getNome()}\n" +
                $"Posição: {player.getPosicao()}\n" +
                $"Nacionalidade: {player.getNacionalidade()}\n" +
                $"Altura: {player.getAltura()}cm\n" +
                $"Peso: {player.getPeso()}kg\n" +
                $"Data de nascimento: {player.getNascimento()}\n" +
                $"Idade: {player.calculaIdade()} anos\n" +
                $"Tempo para se aposentar: {player.calculaAposentadoria()} anos\n");
            Console.ReadKey();
        }
    }
}
