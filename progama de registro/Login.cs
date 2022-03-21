using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Register_login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=SELINELAPTOP;Initial Catalog=login/register;Integrated Security=True");
            cn.Open();

            string consulta = "select Usuario, Contrasena from login where Usuario= '" + txtLUsuario.Text + "' and Contrasena= '" + txtLContraseña.Text + "' ";

            SqlCommand cmd = new SqlCommand(consulta, cn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("exito!");
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no existen");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 acc = new Form1();
            acc.Show();
            this.Hide();
        }
    }
}
