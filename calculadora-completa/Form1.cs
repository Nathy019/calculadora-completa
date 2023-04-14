using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora_completa
{
    public partial class Form1 : Form
    {
        decimal valor1=0, valor2 = 0;
        string operacao = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "DIV";
                labeloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "") 
            {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = " ";
            operacao = "MULT";
            labeloperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "") 
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = " ";
                operacao = "SUB";
                labeloperacao.Text = "-";
            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor efetuado a soma");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "POR";
                labeloperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor efetuado a soma");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labeloperacao.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "EXP";
                labeloperacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor efetuado a expotenciação");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
             textBoxResultado.Text =Convert.ToString(Math.Sqrt(Convert.ToDouble(valor1)));
            labeloperacao.Text = "^";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = Convert.ToString(1 / valor1);
            labeloperacao.Text= "^";
        }

        private void bntrest_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxResultado.Text,CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "resto";
            labeloperacao.Text = "!";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "EXP")
            {
                textBoxResultado.Text =
                    Convert.ToString(Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
                    
            }
            else if (operacao == "RAIZ")
            {
               
            }
            else if (operacao == "resto")
            {
               textBoxResultado.Text = Convert.ToString(Convert.ToDouble(valor1 % valor2));
            }
            else
            {
               textBoxResultado.Text =  Convert.ToString((valor1 /100)* valor2);
            }         
        }
    }
}
