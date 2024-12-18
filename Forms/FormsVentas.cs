using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gina.Forms
{
    public partial class FormsVentas : Form
    {
        public FormsVentas()
        {
            InitializeComponent();
            Sumatoria();
        }

        private void Sumatoria()
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL para sumar el campo 'monto'
            string query = "SELECT SUM(monto) AS TotalMonto FROM registrosusuarios";

            try
            {
                // Crear la conexión con la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // Abrir la conexión

                    // Crear el comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener el resultado
                        object result = cmd.ExecuteScalar();

                        // Verificar si el resultado es válido y asignarlo al TextBox
                        if (result != DBNull.Value && result != null)
                        {
                            // Mostrar el resultado formateado como decimal con 2 decimales
                            txtVentas.Text = Convert.ToDecimal(result).ToString("F2");
                        }
                        else
                        {
                            txtVentas.Text = "0.00"; // Mostrar 0.00 si no hay registros
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de fallo
                MessageBox.Show($"Error al sumar el monto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
