using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Importa la librería MySQL

namespace Gina.Forms
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        // Evento para el botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto desde el campo de texto
            string idProducto = txtId.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(idProducto))
            {
                MessageBox.Show("Por favor, ingresa un ID de producto para buscar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cadena de conexión a la base de datos MySQL
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL para obtener los datos del producto
            string query = "SELECT imagen, descripcion, precio, existencia FROM productotienda WHERE id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Abrir la conexión

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Agregar el parámetro del ID
                        cmd.Parameters.AddWithValue("@id", idProducto);

                        // Ejecutar la consulta y obtener los datos
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Si se encuentra el producto
                            if (reader.Read())
                            {
                                // Llenar los campos de texto con los datos del producto
                                txtImagen.Text = reader["imagen"].ToString();
                                txtDescripcion.Text = reader["descripcion"].ToString();
                                txtPrecio.Text = reader["precio"].ToString();
                                txtExistencia.Text = reader["existencia"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("El producto con ese ID no existe.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de que haya un problema con la conexión
                MessageBox.Show($"Error al consultar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón Aceptar (si quieres hacer algo después de la consulta)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar cualquier acción adicional que desees al aceptar.
            MessageBox.Show("Operación completada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
