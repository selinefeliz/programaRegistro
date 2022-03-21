using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Register_login
{
    public partial class register : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SELINELAPTOP;Initial Catalog=login/register;Integrated Security=True");
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into login (Nombre_Completo,Usuario,Contrasena, email) values('" + this.txtRNombre.Text + "' , '" + this.txtRUsuario.Text + "', '" + this.txtRcontra.Text + "', '" + this.txtRDireccion.Text + "' ) ", conn);
            cmd.ExecuteNonQuery(); //para guardar la consulta//
            MessageBox.Show("Registro guardado");
            conn.Close();

            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 acc = new Form1();
            acc.Show();
            this.Hide();
        }
    }
}
