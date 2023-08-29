using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_POO_28_08_23
{
    internal class Jogador
    {
        string nome, posicao, nacionalidade;
        double peso, altura;
        DateTime nascimento;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setPosicao(string posicao) { this.posicao = posicao; }
        public string getPosicao() { return this.posicao; }

        public void setNacionalidade(string nacionalidade) { this.nacionalidade = nacionalidade; }
        public string getNacionalidade() { return nacionalidade; }

        public void setPeso (double peso) { this.peso = peso; }

        public double getPeso() { return peso; }

        public void setAltura(double altura) { this.altura = altura; }

        public double getAltura() { return altura; }

        public void setNascimento(DateTime nascimento) { this.nascimento = nascimento; }
        public DateTime getNascimento() { return nascimento; }

        //Calcula se o aniversário já foi ou não.
        public int calculaIdade()
        {
            int idade = DateTime.Now.Year - this.nascimento.Year;

            if(DateTime.Now.DayOfYear < this.nascimento.DayOfYear)
            {
                idade--;
            }

            return idade;
        }

        public int calculaAposentadoria()
        {
            int id = calculaIdade();
            int tempo = 0;

            if (this.posicao.Equals("defesa")) tempo = 40 - id;
            if (this.posicao.Equals("meio-campo")) tempo = 38 - id;
            if (this.posicao.Equals("atacante")) tempo = 35 - id;
            return tempo;
        }

    } 
}
