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

    }
}
