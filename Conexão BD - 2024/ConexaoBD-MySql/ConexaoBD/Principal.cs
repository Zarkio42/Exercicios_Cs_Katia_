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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Form tela;

        private void btnProduto_Click(object sender, EventArgs e)
        {
            tela = new TelaProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }
    }
}
