using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_par_ou_impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroJogador = 0, numeroComputador = 0, total;

            string nome = txtNome.Text;

            Random dado = new Random();

            numeroComputador = dado.Next(0, 11);
            numeroJogador = Convert.ToInt32(txtValor.Text);

            total = (numeroComputador + numeroJogador);

            MessageBox.Show("Seu Número: " + txtValor.Text + "\nNúmero do computador: " + numeroComputador.ToString() + "\nTotal: " + total.ToString());


            if (rdbImpar.Checked == true)
            {
                if (total % 2 != 0)
                {
                    MessageBox.Show("Você escolheu ímpar. Parabens " + nome + ", você perdeu!");
                }
                else
                {
                    MessageBox.Show("Você escolheu ímpar. " + nome + ", Você perdeu!");
                }

            }
            else
            {
                if (total % 2 == 0)
                {
                    MessageBox.Show("Você escolheu par. Parabens " + nome + ", você ganhou!");
                }
                else
                {
                    MessageBox.Show("Você escolheu par. " + nome + ", você perdeu!");
                }
            }
        }

    }
}
