using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesKatia01
{
    internal class Veiculo
    {
        //declaração dos atributos
        string modelo, marca, chassi, cor;
        int ano;
        double motor;

        //metodos
        public void receber(string mod, string mar, string ch, string c, int a, double m)
        {
            this.modelo = mod;
            this.marca = mar;
            this.chassi = ch;
            this.cor = c;   
            this.ano = a;
            this.motor = m;
        }

        public string retorna()
        {
            string texto = $"Marca: {this.marca}\tModelo: {this.modelo}\tChassi: {this.chassi}\nCor: {this.cor}\tMotor: {this.motor}\tAno: {this.ano}";
            return texto;
        }
    }
}
