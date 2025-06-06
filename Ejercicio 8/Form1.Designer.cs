namespace Ejercicio_8
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
            btncontador = new Button();
            lblcontador = new Label();
            SuspendLayout();
            // 
            // btncontador
            // 
            btncontador.BackColor = Color.FromArgb(255, 255, 192);
            btncontador.Location = new Point(201, 99);
            btncontador.Name = "btncontador";
            btncontador.Size = new Size(112, 34);
            btncontador.TabIndex = 0;
            btncontador.Text = "Tocar";
            btncontador.UseVisualStyleBackColor = false;
            btncontador.Click += btncontador_Click;
            // 
            // lblcontador
            // 
            lblcontador.AutoSize = true;
            lblcontador.BackColor = Color.FromArgb(255, 192, 192);
            lblcontador.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontador.ForeColor = Color.Red;
            lblcontador.Location = new Point(122, 177);
            lblcontador.Name = "lblcontador";
            lblcontador.Size = new Size(155, 81);
            lblcontador.TabIndex = 1;
            lblcontador.Text = "processing.......\r\n\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(496, 450);
            Controls.Add(lblcontador);
            Controls.Add(btncontador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncontador;
        private Label lblcontador;
    }
}
