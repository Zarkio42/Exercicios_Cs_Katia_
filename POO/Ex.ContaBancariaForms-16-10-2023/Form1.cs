namespace Ex.ContaBancariaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form tela;
        private void button2_Click(object sender, EventArgs e)
        {
            tela?.Close();

            tela = new TelaPoupanca
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            pnlTelas.Controls.Add(tela);
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela?.Close();

            tela = new TelaEspecial
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            pnlTelas.Controls.Add(tela);
            tela.Show();
        }
    }
}