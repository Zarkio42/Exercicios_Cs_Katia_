using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesKatia01
{
    internal class Cliente
    {
        //declaração de atributos
        string nome, cpf, endereco, celular;

        //metodos

        public void atribuir(string nome, string cpf, string endereco, string celular)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.celular = celular;
        }

        public string retornar()
        {
            string texto = $"Nome: {this.nome}\tCPF: {this.cpf}\nEndereço: {this.endereco}\tCelular: {this.celular}";
            return texto;
        }

    }
}
