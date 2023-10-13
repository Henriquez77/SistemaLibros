using Org.BouncyCastle.Crypto;
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
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();
        }
        string nombreArchivoUnico = "";
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string rutaArchivo = openFileDialog1.FileName;


                var source = Path.GetFileName(rutaArchivo);


                string carpetaDestino = Path.Combine(Application.StartupPath);


                nombreArchivoUnico = Guid.NewGuid().ToString() + "_" + source.ToString();


                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivoUnico);


                File.Copy(rutaArchivo, rutaDestino);

            }
        }

        private void frmInsertar_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "logo.png");


            if (File.Exists(imagePath))
            {

                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                Libro libro = new Libro();
                libro.TituloLibro = textBox1.Text;
                libro.AutorLibro = textBox2.Text;
                libro.DescripcionLibro = richTextBox1.Text;
                libro.NumejemplaresLibro = Int32.Parse(numericUpDown1.Value.ToString());
                libro.ImagenLibro = nombreArchivoUnico.ToString();
                if (libro.ImagenLibro.ToString() != "" && libro.NumejemplaresLibro.ToString() != "0")
                {
                    DAOLibro objLibro = new DAOLibro();
                    var op = objLibro.insertInto(libro);
                    if (op)
                    {
                        MessageBox.Show("¡Libro guardado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdministrativo frmAdmin = new frmAdministrativo();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("¡Error al guardar el libro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdministrativo frmAdmin = new frmAdministrativo();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
