using MySql.Data.MySqlClient;  // Importar la librería MySQL
using System;
using System.Windows.Forms;

namespace Gina.Forms
{
    public partial class Cambios : Form
    {
        public Cambios()
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

        // Evento para el botón Aceptar (si quieres permitir editar los detalles)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan datos
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtImagen.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtExistencia.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de aceptar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cadena de conexión a la base de datos MySQL
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL para actualizar los datos del producto
            string updateQuery = "UPDATE productotienda SET imagen = @imagen, descripcion = @descripcion, precio = @precio, existencia = @existencia WHERE id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Abrir la conexión

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
                        cmd.Parameters.AddWithValue("@imagen", txtImagen.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text.Trim()));
                        cmd.Parameters.AddWithValue("@existencia", Convert.ToInt32(txtExistencia.Text.Trim()));

                        // Ejecutar la actualización
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el producto. Verifica el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de que haya un problema con la conexión
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cambios_Load(object sender, EventArgs e)
        {

        }
    }
}
