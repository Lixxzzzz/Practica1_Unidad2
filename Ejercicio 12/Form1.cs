namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {

                if (double.TryParse(textBox1.Text, out double celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    label1.Text = $"Temperatura en Fahrenheit: {fahrenheit:F2}°F";
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

}