
       
namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.AddRange(new string[] { "Rojo", "Verde", "Azul" });


            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;

            }
        }
    }
}



