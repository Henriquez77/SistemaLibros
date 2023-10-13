using MySqlX.XDevAPI.Relational;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void Signup_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "logo.png");


            if (File.Exists(imagePath))
            {

                pictureBox1.Image = Image.FromFile(imagePath);
            }
            await LoadRolesAsync();

        }
        private async Task LoadRolesAsync()
        {
            DAORol daoRoles = new DAORol();
            var roles = await Task.Run(() => daoRoles.getAll());

            if (roles != null)
            {
                foreach (var role in roles)
                {
                    comboBox1.Items.Add(role.NombreRol.ToString());
                }

               
            }
            else
            {
                // Manejar el caso en el que roles es nulo, por ejemplo, mostrar un mensaje de error.
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Usuario objUsuario = new Usuario();
            DAOUsuario objDAOUsuario = new DAOUsuario();
            objUsuario.NombreUsuario = textBox3.Text;
            objUsuario.AliasUsuario = textBox1.Text;
            objUsuario.ContraseniaUsuario = textBox2.Text;
            var rolText = comboBox1.Text;
            if (rolText.Equals("Administrador"))
            {
                objUsuario.RolidUsuario = 1;
            }
            else
            {
                objUsuario.RolidUsuario = 2;
            }
            var acction = objDAOUsuario.insertInto(objUsuario);
            if (acction)
            {
                MessageBox.Show("¡Usuario creado con exito!");
                Login frmLogin = new Login();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Error al crear el usuario!");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
