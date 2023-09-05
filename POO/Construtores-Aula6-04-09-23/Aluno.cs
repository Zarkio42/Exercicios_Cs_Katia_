using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores_Aula6_04_09_23
{
    internal class Aluno
    {
        int ra;
        string nome, curso, turma;

        public Aluno(int ra, string nome, string curso, string turma)
        {
            this.ra = ra;
            this.nome = nome;
            this.curso = curso;
            this.turma = turma;
        }

        public int getRa() { return ra; }
        public string getNome() { return nome; }
        public string getCurso() { return curso; }  
        public string getTurma() { return turma; }

    }
}
