namespace Ejercicio_4
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
            Num1 = new TextBox();
            Num2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BackColor = Color.FromArgb(128, 255, 255);
            Num1.Location = new Point(22, 110);
            Num1.Name = "Num1";
            Num1.Size = new Size(150, 31);
            Num1.TabIndex = 0;
            // 
            // Num2
            // 
            Num2.BackColor = Color.FromArgb(128, 255, 255);
            Num2.Location = new Point(317, 110);
            Num2.Name = "Num2";
            Num2.Size = new Size(150, 31);
            Num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(489, 113);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Resultado\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(190, 110);
            button1.Name = "button1";
            button1.Size = new Size(108, 31);
            button1.TabIndex = 3;
            button1.Text = "Sumar +";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Form1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 19);
            label2.Name = "label2";
            label2.Size = new Size(173, 35);
            label2.TabIndex = 4;
            label2.Text = "Sumatoria";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(687, 234);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1;
        private TextBox Num2;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}
