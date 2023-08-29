using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Classes_Katia
{
    
    internal class Funcionario
    {
        //declaração dos atributos
        string nome, cargo;
        double salario;
        DateTime nascimento;

        //declaração dos métodos
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public void setNascimento(DateTime nascimento)
        {
            this.nascimento = nascimento;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCargo()
        {
            return this.cargo;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public DateTime getNascimento()
        {
            return this.nascimento;
        }

        public int calculaIdade()
        {
            int idade = DateTime.Now.Year - this.nascimento.Year;
            if (this.nascimento.DayOfYear > DateTime.Now.DayOfYear)
            {
                idade--;
            }
            return idade;
        }
    }

    
}
