namespace Ejercicio_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEntrada = new TextBox();
            btnvalidar = new Button();
            lblresultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(137, 100);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(150, 31);
            txtEntrada.TabIndex = 0;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.FromArgb(192, 255, 192);
            btnvalidar.Location = new Point(152, 172);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(112, 34);
            btnvalidar.TabIndex = 1;
            btnvalidar.Text = "Aceptar";
            btnvalidar.UseVisualStyleBackColor = false;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(125, 261);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(90, 25);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "Resultado\r\n";
            lblresultado.Click += lblresultado_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 23);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 3;
            label1.Text = "Ingresar numero!\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(441, 450);
            Controls.Add(label1);
            Controls.Add(lblresultado);
            Controls.Add(btnvalidar);
            Controls.Add(txtEntrada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntrada;
        private Button btnvalidar;
        private Label lblresultado;
        private Label label1;
    }
}
