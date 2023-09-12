using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6_Katia_POO_11_09_23
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        string numero = "";
        Candidato alguem;
        List<Candidato> candidatos = new List<Candidato>();
        int branco = 0, nulo = 0;

        private void insereCandidato()
        {
            alguem = new Candidato("Antonio Silva", "Sol", "Antonio.jpg", 12, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Joana Lima", "Nuvem", "Joana.jpg", 15, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Vivian", "Lua", "Vivian.jpg", 21, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Frederico Ferreira", "Raio", "Frederico.jpg", 29, 0);
            candidatos.Add(alguem);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            numero = "branco";
            btnConfirmar.Enabled = true;
            lbName.Text = "VOTO EM BRANCO";
        }

        private void preencher(string n)
        {
            SoundPlayer som = new SoundPlayer(@"C:\Users\curso.ads2\Desktop\exercicios\Aula6-Katia-POO-11-09-23\som\Tecla.wav");
            som.Play();
            if (numero.Length == 0) { txt1.Text = n; }
            if (numero.Length == 1) 
            { 
                txt2.Text = n;
                int valido = 0;
                numero += n;
                for (int i = 0; i < candidatos.Count; i++)
                {
                    if (candidatos[i].getNum() == Convert.ToInt32(numero))
                    {
                        img1.Image = System.Drawing.Image.FromFile
                        (@"C:\Users\curso.ads2\Desktop\exercicios\Aula6-Katia-POO-11-09-23\img\" +
                        candidatos[i].getFoto());
                        lbName.Text = candidatos[i].getNome();
                        lbChapa.Text = candidatos[i].getChapa();
                        btnConfirmar.Enabled = true;
                        valido = 1;
                    }
                }
                if(valido == 0) { lbName.Text = "VOTO NULO"; }
            }
            numero += n;
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            img1.Image = null;
            lbName.Text = null;
            lbChapa.Text = null;
            btnConfirmar.Enabled = false;
            numero = "";
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            insereCandidato();
            txt1.Enabled = false;
            txt2.Enabled = false;
            btnConfirmar.Enabled = false;
        }
    }
}
