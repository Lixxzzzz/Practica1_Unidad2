namespace Ejercicio_10
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
            btnmensaje = new Button();
            SuspendLayout();
            // 
            // btnmensaje
            // 
            btnmensaje.Location = new Point(134, 198);
            btnmensaje.Name = "btnmensaje";
            btnmensaje.Size = new Size(274, 34);
            btnmensaje.TabIndex = 0;
            btnmensaje.Text = "Mostrar mensaje";
            btnmensaje.UseVisualStyleBackColor = true;
            btnmensaje.Click += btnmensaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(557, 450);
            Controls.Add(btnmensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnmensaje;
    }
}
