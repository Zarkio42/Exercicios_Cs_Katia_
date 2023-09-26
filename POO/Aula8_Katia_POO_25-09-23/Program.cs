using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Katia_POO_25_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto(1, "Oléo", 8.8));
            lista.Add(new Produto(2, "Arroz", 25.8));
            lista.Insert(0, new Produto(3, "Feijão", 8.9));
            Produto p = new Produto(0, "", 0);

            Console.WriteLine("Informe o código do produto: ");
            int.TryParse(Console.ReadLine(), out );
            Console.WriteLine("Informe a descrição do produto: ");
            p.produtoNome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            double.TryParse(Console.ReadLine(), out p.produtoPreco);
            lista.Insert(0, p);

            lista.Sort();

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{lista[i].produtoId} - {lista[i].produtoNome} -" +
                    $" {lista[i].produtoPreco.ToString("c")}");
            }
            Console.ReadKey();

            //List<string> nome = new List<string>();
            //List<int> numero = new List<int>();
            //nome.Add("Joana");
            //nome.Add("Fred");
            //nome.Insert(0,"");r
            //nome.Remove("Joana");
            //nome.RemoveAt(1);
        }
    }
}
