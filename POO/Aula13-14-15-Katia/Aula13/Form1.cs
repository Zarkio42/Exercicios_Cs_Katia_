using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContaCorrente cc = new ContaCorrente();
        Manipula arquivo = new Manipula();
        Conexao con = new Conexao();

        private void btncriar_Click(object sender, EventArgs e)
        {
            //arquivo
            cc.Agencia=txtagencia.Text;
            cc.NumConta = txtconta.Text;
            cc.Titular = txttitular.Text;
            cc.Saldo=Convert.ToDouble(txtsaldo.Text);
            cc.Limite = Convert.ToDouble(txtlimite.Text);
            MessageBox.Show("Conta criada com sucesso!");
            arquivo.Gravar(cc.Agencia+";"+cc.NumConta+";"+
            cc.Titular+";"+cc.Saldo+";"+cc.Limite);

            //banco de dados
            string sql = $"insert into tb_conta values('{cc.Agencia}', '{cc.NumConta}', '{cc.Titular}'," +
                $"'{cc.Saldo}', '{cc.Limite}')";
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Cadastrado com sucesso");
                else MessageBox.Show("Não foi possivel cadastrar!");
            }
            else { MessageBox.Show("Erro ao acessar o banco"); }
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(txtvalor.Text));
            txtsaldo.Text = cc.Saldo.ToString();
            txtvalor.Text = "";
            arquivo.Alterar(cc);

            //Manipulando db

            string sql = $"update tb_conta set saldo={cc.Saldo} where " +
                $"num_conta='{cc.NumConta}'";
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Deposito efetuado com sucesso");
                else MessageBox.Show("Não foi possivel depositar!");
            }
            else { MessageBox.Show("Erro ao acessar o banco"); }
        }

        private void btnsacar_Click(object sender, EventArgs e)
        {
            cc.Sacar(Convert.ToDouble(txtvalor.Text));
            txtsaldo.Text = cc.Saldo.ToString();
            txtvalor.Text = "";
            arquivo.Alterar(cc);

            //Manipulando db

            string sql = $"update tb_conta set saldo={cc.Saldo} where " +
                $"num_conta='{cc.NumConta}'";
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Saque efetuado com sucesso");
                else MessageBox.Show("Não foi possível sacar!");
            }
            else { MessageBox.Show("Erro ao acessar o banco"); }
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Agência: {cc.Agencia}" +
            $"\nNúmero da conta: {cc.NumConta}\nTitular: {cc.Titular}" +
            $"\nSaldo:{cc.Saldo}\nLimite: {cc.Limite}" +
            $"\nValor do Tributo: {cc.CalculaTributo()}");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cc=new ContaCorrente();
            cc.NumConta = txtconta.Text;
            arquivo.Apagar(cc);
            MessageBox.Show("Exclído com sucesso!");
            txtconta.Text = "";
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            cc = new ContaCorrente();
            cc.NumConta=txtconta.Text;
            ContaCorrente conta = new ContaCorrente();
            conta = arquivo.Pesquisar(cc);
            txtagencia.Text = conta.Agencia;
            txtsaldo.Text = conta.Saldo.ToString();
            txttitular.Text = conta.Titular;
            txtlimite.Text = conta.Limite.ToString();
        }

    }
}
