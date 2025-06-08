using System.Data;

namespace Ejercicio_16
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

        private void btn0_Click(object sender, EventArgs e)
        {
            // numero 0
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // numero 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // numero 2
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // numero 3
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //  numero 4
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // numero 5
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // numero 6
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // numero 7
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // numero 8
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            // numero 9
            textBox1.Text += "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borrar el contenido del TextBox
            textBox1.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Mostrar el resultado de la operación en el TextBox
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1: // Suma
                    resultado = valor1 + valor2;
                    break;
                case 2: // Resta
                    resultado = valor1 - valor2;
                    break;
                case 3: // Multiplicación 
                    resultado = valor1 * valor2;
                    break;
                case 4: // División
                    resultado = valor1 / valor2;
                    break;
            }


            textBox1.Text = resultado.ToString();


        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            // Sumar el valor actual al TextBox
            operacion = 1; // Indica que la operación es suma
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // Resta el valor actual al TextBox
            operacion = 2; // Indica que la operación es resta
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // Multiplicación 
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // división
            operacion = 4;
            valor1 += Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // Agregar un punto decimal al TextBox
            textBox1.Text = textBox1.Text + ".";
        }
    }
}

