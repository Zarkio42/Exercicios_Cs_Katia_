using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Properties_Aula7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.Run(new Supermercado());
            //Identifique as classes e crie um programa utilizando properties para a seguinte especificação:
            //Um supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma quantidade
            //em estoque. Um pedido de um cliente é composto por itens, onde cada item especifica o produto que o cliente
            //deseja e a respectiva quantidade.
        }
    }
}
