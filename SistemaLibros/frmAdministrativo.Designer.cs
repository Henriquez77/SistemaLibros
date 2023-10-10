namespace SistemaLibros
{
    partial class frmAdministrativo
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
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(776, 7);
            label6.Name = "label6";
            label6.Size = new Size(17, 17);
            label6.TabIndex = 20;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // frmAdministrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdministrativo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdministrativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
    }
}