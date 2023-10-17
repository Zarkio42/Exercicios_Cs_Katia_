using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbAdicional.Visible = false;
            txtAdicional.Visible = false;
        }

        Ingresso x;

        private void radioBtnIngresso_CheckedChanged(object sender, EventArgs e)
        {
           
            radioBtnIngressoVip.Checked = false;
            lbAdicional.Visible = false;
            txtAdicional.Visible = false;
            
        }

        private void radioBtnIngressoVip_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnIngresso.Checked = false;
            lbAdicional.Visible = true;
            txtAdicional.Visible = true;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radioBtnIngresso.Checked)
            {
                x = new Ingresso(Convert.ToDouble(txtValorIngresso.Text));
                MessageBox.Show(x.toString());
            }
            if (radioBtnIngressoVip.Checked)
            {
                IngressoVip x = new IngressoVip(Convert.ToDouble(txtValorIngresso.Text), 
                    Convert.ToDouble(txtAdicional.Text));
                MessageBox.Show(x.toString() + "\n" + x.calcular());
            }

        }
    }
}
