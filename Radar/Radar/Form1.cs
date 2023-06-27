using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaEmerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLimite_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtVelocidade_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtVelocidade.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Não há cálculos sem valores! Por Favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double velocidade, limite, multa, pontos;
                
                velocidade = Convert.ToDouble(txtVelocidade.Text);
                limite = Convert.ToDouble(txtLimite.Text);
                if(velocidade <= limite)
                {
                    lblMulta.Text = "0";
                    lblPontos.Text = "0";
                }
                else if(velocidade > limite && velocidade <= limite + (limite * 0.15))
                {
                    lblMulta.Text = "130.16";
                    lblPontos.Text = "+4";

                }
                else if (velocidade > limite + (limite * 0.15) && velocidade <= limite + (limite * 0.35))
                {
                    lblMulta.Text = "195,23";
                    lblPontos.Text = "+5";

                }
                else if (velocidade > limite + (limite * 0.35))
                {
                    lblMulta.Text = "880,40";
                    lblPontos.Text = "+7";

                }
               
            }
        }
    }
}
