using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;  // Importar la librería MySQL

namespace Gina.Forms
{
    public partial class Altas : Form
    {
        public Altas()
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
                    connection.Open();  // Abrir la conexión

                    using (MySqlCommand cmdCount = new MySqlCommand(countQuery, connection))
                    {
                        // Ejecutar la consulta y obtener el número de registros
                        int count = Convert.ToInt32(cmdCount.ExecuteScalar());

                        // Validar si hay más de 10 productos
                        if (count >= 10)
                        {
                            MessageBox.Show("No se puede modificar los productos porque ya hay 10 o más registros.", "Condición No Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Obtener los valores de los campos de texto
                        string idProducto = txtId.Text.Trim();
                        string imagen = txtImagen.Text.Trim();
                        string descripcion = txtDescripcion.Text.Trim();
                        string precioStr = txtPrecio.Text.Trim();
                        string existenciaStr = txtExistencia.Text.Trim();

                        // Validar que los campos no estén vacíos
                        if (string.IsNullOrEmpty(idProducto) || string.IsNullOrEmpty(imagen) ||
                            string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(precioStr) ||
                            string.IsNullOrEmpty(existenciaStr))
                        {
                            MessageBox.Show("Por favor, completa todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Convertir precio y existencia a los tipos adecuados
                        if (!float.TryParse(precioStr, out float precio))
                        {
                            MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!int.TryParse(existenciaStr, out int existencia))
                        {
                            MessageBox.Show("La existencia debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Consulta SQL para insertar el producto
                        string query = "INSERT INTO productotienda (id, imagen, descripcion, precio, existencia) " +
                                       "VALUES (@id, @imagen, @descripcion, @precio, @existencia)";

                        try
                        {
                            // Crear el comando SQL para insertar el producto
                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                // Añadir los parámetros al comando para evitar inyección SQL
                                cmd.Parameters.AddWithValue("@id", idProducto);
                                cmd.Parameters.AddWithValue("@imagen", imagen);
                                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                                cmd.Parameters.AddWithValue("@precio", precio);
                                cmd.Parameters.AddWithValue("@existencia", existencia);

                                // Ejecutar el comando para insertar el producto
                                cmd.ExecuteNonQuery();

                                // Mostrar mensaje de éxito
                                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Limpiar los campos después de agregar el producto (opcional)
                                txtId.Clear();
                                txtImagen.Clear();
                                txtDescripcion.Clear();
                                txtPrecio.Clear();
                                txtExistencia.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Mostrar mensaje de error en caso de falla en el comando SQL
                            MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de que haya un problema con la conexión
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
