using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RegistroDataGrid
{
    internal class ConexionBD
    {
        private MySqlConnection conexion;
        private string cadenaConexion = "Server=localhost;Port=3307; Uid=root; Pwd=maritza; Database=tecnologico;";
        public MySqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new MySqlConnection(cadenaConexion);

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
    ConexionBD conexion = new ConexionBD();

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
}
try
{
    // Se define la consulta SQL para verificar si existe un registro con los datos ingresados.
    string consulta = "SELECT COUNT(*) FROM registro WHERE usuario = @Usuario AND Contraseña = @Contraseña AND Correo = @Correo";

