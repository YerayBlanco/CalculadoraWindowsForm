using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        { //Multiplicación.
            operacion = 3;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Número 2.
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Botón resta.
            operacion = 2;

            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Botón igual.

            valor2 = double.Parse(textBox1.Text);

            switch (operacion)
            {
                case 1:

                    resultado = valor1 + valor2;
                    break;

                case 2:

                    resultado = valor1 - valor2;
                    break;

                case 3:

                    resultado = valor1 * valor2;
                    break;

                case 4:

                    resultado = valor1 / valor2;
                    break;

                case 5:

                    resultado = Math.Pow(valor1, valor2);

                    break;

            }

            textBox1.Text = resultado.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Número 0.
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Número 1.
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Número 3.
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Número 4.
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Número 5.
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Número 6.
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Número 7.
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Número 8.
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Número 9.
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Botón de Borrar. Añade a la pantall un valor vacio.
            textBox1.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Suma.
            operacion = 1;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        { //División.
            operacion = 4;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnExpo_Click(object sender, EventArgs e)
        { //Exponencial.

            operacion = 5;
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";

        }
    }
}
