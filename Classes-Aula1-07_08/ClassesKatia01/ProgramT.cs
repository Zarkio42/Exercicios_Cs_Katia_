using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesKatia01
{
    internal class ProgramT
    {
        static void Main(string[] args)
        {
            //declaração e instanciação de objetos

            Veiculo carro = new Veiculo();

            Console.WriteLine("Digite a marca: ");
            string ma = Console.ReadLine();

            Console.WriteLine("Digite o modelo: ");
            string md = Console.ReadLine();

            Console.WriteLine("Digite o chassi: ");
            string ch = Console.ReadLine();

            Console.WriteLine("Digite a cor: ");
            string c = Console.ReadLine();

            Console.WriteLine("Digite o ano: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Digite o motor: ");
            double.TryParse(Console.ReadLine(), out double mt);

            Console.Clear();

            carro.receber(md, ma, ch, c, a, mt);

            Cliente pessoa = new Cliente();

            Console.WriteLine("Digite o nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Cliente: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o endereço do Cliente: ");
            string end = Console.ReadLine();
            Console.WriteLine("Digite o número de telefone do Cliente: ");
            string cel = Console.ReadLine();

            Console.Clear();

            pessoa.atribuir(nome, cpf, end, cel);

            Console.WriteLine("\n\nDados do Cliente");
            Console.WriteLine(pessoa.retornar());
            Console.WriteLine("\n\nDados do Carro");
            Console.WriteLine(carro.retorna());

            Console.ReadKey();
        }
    }
}
