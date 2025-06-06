namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label1.Text = " Usted a Selecionado (Excelente)";

            if (radioButton2.Checked == true)
                label1.Text = " Usted a Selecionado (Bueno)";

            if (radioButton3.Checked == true)
                label1.Text = " Usted a Selecionado (Muy malo)";
        }
    }
}
