namespace SistemaLibros
{
    partial class frmActualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 397);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 23);
            numericUpDown1.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 381);
            label7.Name = "label7";
            label7.Size = new Size(79, 13);
            label7.TabIndex = 34;
            label7.Text = "N° Ejemplares";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 311);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(176, 68);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 292);
            label5.Name = "label5";
            label5.Size = new Size(70, 13);
            label5.TabIndex = 32;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 249);
            label4.Name = "label4";
            label4.Size = new Size(40, 13);
            label4.TabIndex = 31;
            label4.Text = "Autor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 29;
            label3.Text = "Titulo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 174);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 27;
            label2.Text = "Modificar Libro";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(65, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 25;
            label1.Text = "Biblioteca UNAB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(221, 6);
            label6.Name = "label6";
            label6.Size = new Size(17, 17);
            label6.TabIndex = 24;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(131, 486);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 38;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(19, 486);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 37;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(38, 439);
            label8.Name = "label8";
            label8.Size = new Size(172, 13);
            label8.TabIndex = 39;
            label8.Text = "¡Imposible modificar la imagen!";
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 540);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmActualizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmActualizar";
            Load += frmActualizar_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label7;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Button button3;
        private Button button2;
        private Label label8;
    }
}