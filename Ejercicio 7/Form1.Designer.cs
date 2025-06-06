namespace Ejercicio_7
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
            lstElementos = new ListBox();
            button1 = new Button();
            txtElementos = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 27;
            lstElementos.Location = new Point(24, 161);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(526, 274);
            lstElementos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(393, 87);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(24, 92);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(341, 31);
            txtElementos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 26);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 3;
            label1.Text = "Listado\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(586, 474);
            Controls.Add(label1);
            Controls.Add(txtElementos);
            Controls.Add(button1);
            Controls.Add(lstElementos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Button button1;
        private TextBox txtElementos;
        private Label label1;
    }
}
