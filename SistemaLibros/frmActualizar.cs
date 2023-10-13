using SistemaLibros.DAO;
using SistemaLibros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLibros
{
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        public Libro? LibroToUpdate { get; set; }
        DAOLibro objLibro = new DAOLibro();
        Libro libro = new Libro();
        private void frmActualizar_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "logo.png");


            if (File.Exists(imagePath))
            {

                pictureBox1.Image = Image.FromFile(imagePath);
            }
            var list = objLibro.getById(LibroToUpdate);
            textBox1.Text = list.TituloLibro.ToString();
            textBox2.Text = list.AutorLibro.ToString();
            richTextBox1.Text = list.DescripcionLibro.ToString();
            numericUpDown1.Value = list.NumejemplaresLibro;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdministrativo frmAdmin = new frmAdministrativo();
            frmAdmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                libro.IdLibro =  LibroToUpdate.IdLibro;
                libro.TituloLibro = textBox1.Text;
                libro.AutorLibro = textBox2.Text;
                libro.DescripcionLibro = richTextBox1.Text;
                libro.NumejemplaresLibro = Int32.Parse(numericUpDown1.Value.ToString());
      
                if (libro.NumejemplaresLibro.ToString() != "0")
                {

                    var op = objLibro.updateLibro(libro);
                    if (op)
                    {
                        MessageBox.Show("¡Libro actualizado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdministrativo frmAdmin = new frmAdministrativo();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("¡Error al actualizar el libro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Por favor, completa todos los campos antes de guardar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Por favor, completa todos los campos antes de guardar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
