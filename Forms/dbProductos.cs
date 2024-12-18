using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gina.Forms
{
    internal class dbProductos
    {
        private int id_producto;
        private string descripcion;
        private decimal precio;
        private string imagenUrl; // URL de la imagen
        private int existencia;

        private readonly string imageFolderPath = Path.Combine(Application.StartupPath, "img");

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string ImagenUrl { get => imagenUrl; set => imagenUrl = value; }
        public int Existencia { get => existencia; set => existencia = value; }

        public void LlenarBotones(FlowLayoutPanel Contenedor)
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string query = "SELECT id, imagen, descripcion, precio, existencia FROM productotienda";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Id_producto = Convert.ToInt32(reader["id"]);
                                ImagenUrl = reader["imagen"].ToString();
                                Descripcion = reader["descripcion"].ToString();
                                Precio = Convert.ToDecimal(reader["precio"]);
                                Existencia = Convert.ToInt32(reader["existencia"]);

                                // Descargar la imagen desde la URL o usar una predeterminada
                                Image imgProducto = ObtenerImagenDesdeURL(ImagenUrl);

                                // Crear el botón personalizado
                                btnRopa btn = new btnRopa
                                {
                                    Id = Id_producto,
                                    Descripcion = Descripcion,
                                    Precio = "$" + Precio.ToString("N2"),
                                    ImgProducto = imgProducto
                                };

                                // Agregar el botón al FlowLayoutPanel
                                Contenedor.Controls.Add(btn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ObtenerImagenDesdeURL(string url)
        {
            Image imagen;

            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = client.DownloadData(url); // Descargar la imagen como byte[]
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        imagen = Image.FromStream(ms); // Convertir a Image
                    }
                }
            }
            catch
            {
                // Si hay error, usar una imagen predeterminada
                string defaultImagePath = Path.Combine(imageFolderPath, "default.png");
                if (File.Exists(defaultImagePath))
                {
                    imagen = Image.FromFile(defaultImagePath);
                }
                else
                {
                    MessageBox.Show("No se encontró la imagen predeterminada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    imagen = new Bitmap(100, 100); // Imagen vacía si no existe la predeterminada
                }
            }

            return imagen;
        }
    }
}
