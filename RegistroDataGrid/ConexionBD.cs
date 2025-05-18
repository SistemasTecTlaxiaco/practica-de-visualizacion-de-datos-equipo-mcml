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

    }
}
