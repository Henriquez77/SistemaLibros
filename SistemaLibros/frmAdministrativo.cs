using Google.Protobuf.WellKnownTypes;
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
    public partial class frmAdministrativo : Form
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }
        List<Libro> libros = new List<Libro>();
        DAOLibro objLibro = new DAOLibro();
        Libro libro = new Libro();
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertar frmInsert = new frmInsertar();
            frmInsert.Show();
            this.Hide();
        }
        public async Task cargarGrid()
        {
            
            libros = await Task.Run(() => objLibro.getAll());


            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Titulo", typeof(string));
            dt.Columns.Add("Autor", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("ImagenPath", typeof(string));
            dt.Columns.Add("Imagen", typeof(Image));


            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.Name = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Actualizar";
            updateButtonColumn.Text = "Actualizar";
            updateButtonColumn.Name = "Actualizar";
            updateButtonColumn.UseColumnTextForButtonValue = true;

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add(deleteButtonColumn);
            dataGridView1.Columns.Add(updateButtonColumn);




            foreach (Libro libro in libros)
            {
                string imagenPath = Path.Combine(Application.StartupPath, libro.ImagenLibro);
                if (File.Exists(imagenPath))
                {

                    Image imagen = Image.FromFile(imagenPath);


                    dt.Rows.Add(libro.IdLibro, libro.TituloLibro, libro.AutorLibro, libro.DescripcionLibro, imagenPath, imagen);
                }
            }


            dataGridView1.DataSource = dt;


            dataGridView1.Columns["ImagenPath"].Visible = false;
        }
        private async void frmAdministrativo_Load(object sender, EventArgs e)
        {
            await cargarGrid();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Imagen"].Index && e.RowIndex >= 0)
            {

                e.Value = ResizeImage((Image)e.Value, 50, 50);
                e.FormattingApplied = true;
            }
        }
        private Image ResizeImage(Image originalImage, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(resizedImage))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gr.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                {
                    
                    libro.IdLibro = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este libro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var op = objLibro.deleteLibro(libro);
                        if (op)
                        {
                            MessageBox.Show("¡Libro eliminado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAdministrativo frmAdmin = new frmAdministrativo();
                            frmAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else if (e.ColumnIndex == dataGridView1.Columns["Actualizar"].Index)
                {

                    libro.IdLibro = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    DialogResult result = MessageBox.Show("¿Desea actualizar este libro?", "Confirmar Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        frmActualizar frmActu = new frmActualizar();
                        frmActu.LibroToUpdate = libro;
                        frmActu.Show();
                        this.Hide();

                    }

                }
            }
        }
    }
}
