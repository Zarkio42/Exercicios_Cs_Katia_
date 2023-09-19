using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Katia_POO_11_09_23
{
    internal class Candidato
    {
        string nome, chapa, foto;
        int num, voto;

        public Candidato(string nome, string chapa, string foto, int num, int voto)
        {
            this.nome = nome;
            this.chapa = chapa;
            this.foto = foto;
            this.num = num;
            this.voto = voto;
        }

        public string getNome() { return nome; }
        public string getChapa() { return chapa; }
        public string getFoto() { return foto; }
        public int getVoto() { return voto; }
        public int getNum() { return num; }

        public void setVoto(int voto) { this.voto = voto; }

    }
}
