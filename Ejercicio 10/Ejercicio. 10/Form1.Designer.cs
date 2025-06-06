namespace Ejercicio._10
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
            btnMensaje = new Button();
            SuspendLayout();
            // 
            // btnMensaje
            // 
            btnMensaje.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMensaje.Location = new Point(135, 192);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(254, 34);
            btnMensaje.TabIndex = 0;
            btnMensaje.Text = "Toca aqui";
            btnMensaje.UseVisualStyleBackColor = true;
            btnMensaje.Click += btnMensaje_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(528, 450);
            Controls.Add(btnMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensaje;
    }
}
