namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1.Text);
            int num2 = int.Parse(Num2.Text);
            int resultado = num1 + num2;
            label1.Text = "El resultado es: " + resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
