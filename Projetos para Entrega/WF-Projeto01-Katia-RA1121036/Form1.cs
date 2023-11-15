using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Projeto01_Katia_RA1121036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxQuarto.Items.Add("Master (4 pessoas)");
            cbxQuarto.Items.Add("Nobre (2 pessoas)");
            cbxQuarto.Items.Add("Plus (1 pessoas)");
        }
        List<Reserva> reservas = new List<Reserva>();
        double valorTotal = 0;

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value.Hour < 14)
            {
                dtpCheckIn.Value = new DateTime(dtpCheckIn.Value.Year, dtpCheckIn.Value.Month, dtpCheckIn.Value.Day, 14, 0, 0);
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value.Hour > 12)
            {
                dtpCheckOut.Value = new DateTime(dtpCheckOut.Value.Year, dtpCheckOut.Value.Month, dtpCheckOut.Value.Day, 12, 0, 0);
            }
        }

        private void cbxQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuarto.SelectedItem.Equals("Master (4 pessoas)"))
            {
                valorTotal = 540;
            }
            else if (cbxQuarto.SelectedItem.Equals("Nobre (2 pessoas)"))
            {
                valorTotal = 350;
            }
            else if (cbxQuarto.SelectedItem.Equals("Plus (1 pessoas)"))
            {
                valorTotal = 230;
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            DateTime dataMinimaCheckIn = DateTime.Now.AddDays(3);
            if (txtNome.Text != string.Empty && txtCpf.Text != null && txtTelefone.Text != string.Empty && cbxQuarto.SelectedItem != null)
            {
                if (dtpCheckIn.Value <= dtpCheckOut.Value)
                {
                    if (dtpCheckIn.Value > dataMinimaCheckIn)
                    {
                        Reserva novaReserva = new Reserva()
                        {
                            Nome = txtNome.Text,
                            Cpf = Int32.Parse(txtCpf.Text),
                            Telefone = txtTelefone.Text,
                            DataCheckIn = dtpCheckIn.Value,
                            DataCheckOut = dtpCheckOut.Value,
                            QuartoReservado = cbxQuarto.SelectedItem.ToString(),
                            PagamentoPendente = true
                        };
                        MessageBox.Show($"Para que a reserva seja efetuada com sucesso será necessário o depósito de 30% do valor total em até 3 dias úteis.\n" +
                            $"\nTotal: {novaReserva.Calcular(valorTotal).ToString("C")}\n" +
                            $"Valor Antecipado: {(novaReserva.Calcular(valorTotal) * 0.3).ToString("C")}", "Quase lá!", MessageBoxButtons.OK);
                        cbxQuarto.Items.Remove(cbxQuarto.SelectedItem);
                        reservas.Add(novaReserva);
                    }
                    else
                    {
                        MessageBox.Show("O check in deve ser feito com no mínimo 3 dias de antecedência.", "Erro", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    MessageBox.Show("A data selecionada para o check out é inválida.", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK);
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder exibirReservas = new StringBuilder(); //o stringbuilder reune todas as infos em um unico messagebox.

            foreach (var x in reservas)
            {
                exibirReservas.AppendLine($"Quarto {x.QuartoReservado} reservado para o Sr(a) {x.Nome} de {x.DataCheckIn} à {x.DataCheckOut}.\n" +
                    $"\nPagamento {(x.PagamentoPendente ? "Pendente" : "Aprovado")}\n");
            }

            MessageBox.Show(exibirReservas.ToString(), "Todas as Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information); //algumas funções novasque achei legal.

        }


    }
}
