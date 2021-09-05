using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            // tem que colocar depois do igual para concatenar com o que já tinha antes 
            // pode ser tbm +=
            txtResultado.Text = txtResultado.Text + "1";
        }
private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";

        } 
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";

        }
private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";

        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label1.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        { 
        //{if (valor2 != 0)
            valor2 = int.Parse(txtResultado.Text);

      //  else { MessageBox.Show("INFORME UM VALOR PARA CONCLUIR A OPERAÇÃO")}

            if (operacao == "DIVISÃO") 
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if(operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);

            }
            else if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);

            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);

            }
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "MULT";
            label1.Text = "×";

            }
            else
            {
                MessageBox.Show("INFORME UM VALOR PARA EFETUAR A OPERAÇÃO");
            }
           
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "SUB";
                label1.Text = "-";
            }
            else
            {
                MessageBox.Show("INFORME UM VALOR PARA EFETUAR A OPERAÇÃO");
            }
           
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "SOMA";
                label1.Text = "+";
            }
            else
            {
                MessageBox.Show("INFORME UM VALOR PARA EFETUAR A OPERAÇÃO");
            }
           
        }

        private void buttonDividir_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Crimson;
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "DIVISÃO";
                label1.Text = "÷";
            }
            else
            {
                MessageBox.Show("INFORME UM VALOR PARA EFETUAR A OPERAÇÃO");
            }
        }
    }
}
