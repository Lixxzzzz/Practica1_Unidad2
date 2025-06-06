namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btncontador_Click(object sender, EventArgs e)
        {
            contador++;
            lblcontador.Text = $"Botón presionado: {contador} veces";


        }
    }
}
