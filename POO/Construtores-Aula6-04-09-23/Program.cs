using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtores_Aula6_04_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Curso curso = new Curso();
            // Console.WriteLine(curso.getNome() + " - " + curso.getPeriodo());

            Application.Run(new FormAluno());

            Console.ReadKey();
        }
    }
}
