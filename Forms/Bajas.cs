using MySql.Data.MySqlClient;  // Importar la librería MySQL
using System;
using System.Windows.Forms;

namespace Gina.Forms
{
    public partial class Bajas : Form
    {
        public Bajas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            string countQuery = "SELECT COUNT(*) FROM productotienda";


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmdCount = new MySqlCommand(countQuery, connection))
                    {
                        // Ejecutar la consulta y obtener el número de registros
                        int count = Convert.ToInt32(cmdCount.ExecuteScalar());

                        // Validar si hay menos o igual a 6 registros
                        if (count <= 6)
                        {
                            MessageBox.Show("No se puede modificar los productos.", "Condición No Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Obtener el ID del producto desde el campo de texto
                        string idProducto = txtId.Text.Trim();

                        // Validar que el campo no esté vacío
                        if (string.IsNullOrEmpty(idProducto))
                        {
                            MessageBox.Show("Por favor, ingresa un ID de producto.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Consulta para verificar si el producto existe en la base de datos
                        string checkQuery = "SELECT COUNT(*) FROM productotienda WHERE id = @id";

                        using (MySqlCommand cmdCheck = new MySqlCommand(checkQuery, connection))
                        {
                            cmdCheck.Parameters.AddWithValue("@id", idProducto);

                            int productCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                            if (productCount == 0)
                            {
                                MessageBox.Show("El producto con ese ID no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Si el producto existe, ejecutar la sentencia DELETE
                            string deleteQuery = "DELETE FROM productotienda WHERE id = @id";

                            using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, connection))
                            {
                                cmdDelete.Parameters.AddWithValue("@id", idProducto);

                                // Ejecutar el comando de eliminación
                                cmdDelete.ExecuteNonQuery();

                                // Mostrar mensaje de éxito
                                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Limpiar el campo de ID
                                txtId.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de que haya un problema con la conexión
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
