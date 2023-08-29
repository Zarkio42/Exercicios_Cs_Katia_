using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Aula4_POO
{
    internal class Contato
    {
        private string nome;
        private int idade, numero;

        public void setNome(string nome) { this.nome = nome; }

        public string getNome() { return nome; }

        public void setIdade(int idade) { this.idade = idade; }
        public int getIdade() { return idade; }

        public void setNumero(int numero) { this.numero = numero; }
        public int getNumero() { return numero; }

    }
}
