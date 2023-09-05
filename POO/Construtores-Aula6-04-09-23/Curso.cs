using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_Aula6_04_09_23
{
    internal class Curso
    {
        string nome, periodo, turma;

        public Curso()
        {
            this.nome = "Administração";
            this.periodo = "noturno";
            this.turma = "A1";
        }

        public Curso(string nome)
        {
            this.nome = nome;
            this.periodo = "Noturno";
        }

        public string getNome() { return this.nome; }

        public void setNome(string nome) { this.nome = nome; }
        public string getPeriodo() { return this.periodo; }
        public void setPeriodo(string periodo) { this.periodo = periodo; }
    }
}
