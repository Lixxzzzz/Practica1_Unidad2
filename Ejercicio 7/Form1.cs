using System;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
           
            lstElementos.Items.Add(txtElementos.Text);
            txtElementos.Text = "";
        } 

    }

}

