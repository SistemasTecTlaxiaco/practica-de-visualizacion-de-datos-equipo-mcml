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

                // Se ejecuta la consulta y se obtiene la cantidad de registros que coinciden.
                int count = Convert.ToInt32(comando.ExecuteScalar());


                // Si el resultado es mayor que cero, los datos son correctos.
                if (count > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    // Aquí podrías abrir el formulario principal y ocultar el actual.
                    // new FormPrincipal().Show(); this.Hide();
                }
                else
                {
                    // Si no hay coincidencias, se muestra un mensaje de error.
                    MessageBox.Show("Datos incorrectos. Verifica tu usuario, contraseña y correo.");
                }
                // Se cierra la conexión a la base de datos.
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                // En caso de error en el proceso, se muestra un mensaje con la descripción del error.
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }


        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarDatos()
        {
            try
            {
                // Conexión a la base de datos
                MySqlConnection conn = conexion.AbrirConexion();

                // Consulta SQL
                string consulta = "SELECT * FROM registro";

                // Adaptador y DataTable para llenar el DataGridView
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conn);

            }
            catch (Exception ex)
            {

            }
        }
    }
}

