namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtEntrada.Text, out double numero))
            {
                lblresultado.Text = "Entrada válida: Es un número.";
                lblresultado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("Error: La entrada no es un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblresultado.Text = "Entrada inválida.";
                lblresultado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void lblresultado_Click_1(object sender, EventArgs e)
        {

        }
    }
}

