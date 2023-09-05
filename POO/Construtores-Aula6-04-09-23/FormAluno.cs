using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtores_Aula6_04_09_23
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        Curso[] cursos = {new Curso(), new Curso("Analise e Desenvolvimento de Sistemas"),
            new Curso("Direito"), new Curso("Fisioterapia")};

        Aluno[] alunos = { new Aluno(2, "Jõao", "Medicina", "A3"), new Aluno(1,"Pedro", "ADS", "B6") };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                comboBoxCurso.Items.Add(cursos[i].getNome());
            }

            for (int i = 0; i < alunos.Length; i++)
            {
                comboBoxTurma.Items.Add(alunos[i].getTurma());
            }

        }

        Aluno alguem;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            alguem = new Aluno(Convert.ToInt32(textRa.Text), textNome.Text,
            comboBoxTurma.Text, comboBoxTurma.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            textRa.Text = alguem.getRa().ToString();
            textNome.Text = alguem.getNome();
            comboBoxCurso.Text = alguem.getCurso();
            comboBoxTurma.Text = alguem.getTurma();
        }
    }
}
