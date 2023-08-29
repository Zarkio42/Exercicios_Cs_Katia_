using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
    internal class Conta
    {
        string nome, cpf;
        double saldo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public double opDepositar(double valorDeposito)
        {
            saldo += valorDeposito;
            return saldo;
        }

        public double opSaque(double valorSaque)
        {
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                return saldo;
            }
            else
            {
                return 0;
            }
        }
    }

}
