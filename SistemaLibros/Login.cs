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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string imagePath = Path.Combine(Application.StartupPath, "logo.png");


            if (File.Exists(imagePath))
            {

                pictureBox1.Image = Image.FromFile(imagePath);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup frmSignUp = new Signup();
            frmSignUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAOUsuario objUsuario = new DAOUsuario();
            Usuario usuario = new Usuario();
            usuario.AliasUsuario = textBox1.Text;
            usuario.ContraseniaUsuario = textBox2.Text;
            bool op = objUsuario.findByNameAndPass(usuario);
            if (op)
            {
                frmAdministrativo frmAdmin = new frmAdministrativo();
                frmAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Contraseña ó Usuario incorrecto!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }
    }
}
