using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoBD
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            cbxCategoria.DataSource = null;
            cbxCategoria.DataSource = con.Retorna("SELECT * FROM tb01_categoria");
            cbxCategoria.DisplayMember = "tb01_descricao";
            cbxCategoria.ValueMember = "id_tb01";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string insere = $"insert into tb02_produto values (null, '{txtNome.Text}', {txtValor.Text}, " +
                $"'{txtDesc.Text}', '{txtCodigo.Text}', {cbxCategoria.SelectedValue});";

            if (con.Executa(insere))
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string atualiza = $"update tb02_produto set tb02_nome='{txtNome.Text}', tb02_valor={txtValor.Text}," +
                $" tb02_descricao='{txtDesc.Text}', tb02_categoriaId={cbxCategoria.SelectedValue} where tb02_codigo=" +
                $"'{txtCodigo.Text}'";
            if (con.Executa(atualiza))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao atualizar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string delete = $"delete from tb02_produto where tb02_codigo='{txtCodigo.Text}'";
            if (txtCodigo.Text != "")
            {
                if (con.Executa(delete)){
                    MessageBox.Show("Excluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir!");
                }
            }
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dt = con.Retorna(
                    $"Select * from tb02_produto where tb02_codigo='{txtCodigo.Text}'");

                txtNome.Text = dt.Rows[0]["tb02_nome"].ToString();
                txtDesc.Text = dt.Rows[0]["tb02_descricao"].ToString();
                cbxCategoria.SelectedValue = Convert.ToInt32(dt.Rows[0]["tb02_categoriaId"].ToString());
                txtValor.Text = dt.Rows[0]["tb02_valor"].ToString();

            }
        }
    }
}
