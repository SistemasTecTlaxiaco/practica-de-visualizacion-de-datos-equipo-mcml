using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace RegistroDataGrid
{
    public partial class Form1 : Form
    {
        ConexionBD conexion = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
                this.CenterToScreen();
                CargarDatos();
            }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;
            string correo = txtCorreo.Text;
            ConexionBD conexion = new ConexionBD();
        
            try
            {
                string consulta = "SELECT COUNT(*) FROM registro WHERE usuario = @Usuario AND Contraseña = @Contraseña AND Correo = @Correo";

                MySqlCommand comando = new MySqlCommand(consulta, conexion.AbrirConexion());
                // Se añaden los parámetros a la consulta para evitar inyecciones SQL.
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@Correo", correo);


        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

