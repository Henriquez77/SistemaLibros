namespace SistemaLibros
{
    partial class frmInsertar
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
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(220, 6);
            label6.Name = "label6";
            label6.Size = new Size(17, 17);
            label6.TabIndex = 10;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(64, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 11;
            label1.Text = "Biblioteca UNAB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 15;
            label3.Text = "Titulo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 174);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 13;
            label2.Text = "Ingresar Libros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 249);
            label4.Name = "label4";
            label4.Size = new Size(40, 13);
            label4.TabIndex = 17;
            label4.Text = "Autor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 292);
            label5.Name = "label5";
            label5.Size = new Size(70, 13);
            label5.TabIndex = 19;
            label5.Text = "Descripcion:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 311);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(176, 68);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 381);
            label7.Name = "label7";
            label7.Size = new Size(79, 13);
            label7.TabIndex = 22;
            label7.Text = "N° Ejemplares";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(34, 397);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(33, 432);
            button1.Name = "button1";
            button1.Size = new Size(177, 23);
            button1.TabIndex = 24;
            button1.Text = "Subir Imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(18, 494);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 25;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(130, 494);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 26;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(243, 540);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "frmInsertar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInsertar";
            Load += frmInsertar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}