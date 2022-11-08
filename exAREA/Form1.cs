using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exAREA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(txbPeso.Text);
                double n2 = double.Parse(txbAltura.Text);

                txbResultado.Text = Math.Round(n1 / (n2 * n2), 3) + "";
                double Resultado;
                Resultado = (n1 / (n2 * n2));
                if (Resultado < 18.5)
                {
                    lblhp.Text = "abaixo do peso ideal";
                    lblhp.ForeColor = Color.Pink;
                }
                else if (Resultado < 24.9)
                {
                    lblhp.Text = "peso ideal, parabéns";
                    lblhp.ForeColor = Color.Green;

                }
                else if (Resultado < 29.9)
                {
                    lblhp.Text = "levemente acima do peso";
                    lblhp.ForeColor = Color.Yellow;

                }
                else if (Resultado < 34.9)
                {
                    lblhp.Text = "obesidade grau 1";
                    lblhp.ForeColor = Color.Orange;

                }
                else if (Resultado < 39.9)
                {
                    lblhp.Text = "obesidade grau 2";
                    lblhp.ForeColor = Color.Orange;

                }
                else if (Resultado > 40)
                {
                    lblhp.Text = "obesidade grau 3";
                    lblhp.ForeColor = Color.Red;

                }

            } catch
            {
                lblhp.Text = "erro";
            }
            


        }

        private void lblN1_Click(object sender, EventArgs e)
        {

        }

        private void lblhp_Click(object sender, EventArgs e)
        {

        }
    }
}
