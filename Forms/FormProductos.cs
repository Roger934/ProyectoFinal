using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gina.Forms
{
    public partial class Productos : Form
    {
        private string tipoUsuario;
        private readonly string imageFolderPath = Path.Combine(Application.StartupPath, "img");


        public Productos(string tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
            this.dwvProductos.CellClick += new DataGridViewCellEventHandler(this.dwvProductos_CellClick);
        }

        // Método para cargar productos y mostrar imágenes
        private void CargarProductos()
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
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Limpiar el FlowLayoutPanel antes de agregar nuevas tarjetas
                        flowLayoutPanel1.Controls.Clear();
                        // Limpiar el DataGridView y agregar columnas manualmente
                        dwvProductos.Columns.Clear();
                        dwvProductos.AutoGenerateColumns = false;

                        // Agregar columnas manuales
                        dwvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "id", Name = "ID" });
                        dwvProductos.Columns.Add(new DataGridViewImageColumn { HeaderText = "Imagen", Name = "Imagen", ImageLayout = DataGridViewImageCellLayout.Zoom });
                        dwvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "descripcion" });
                        dwvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "precio" });
                        dwvProductos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Existencia", DataPropertyName = "existencia", Name = "Existencia" });
                        if (tipoUsuario == "usuario")
                        {
                            DataGridViewTextBoxColumn cantidadColumn = new DataGridViewTextBoxColumn();
                            cantidadColumn.HeaderText = "Cantidad";
                            cantidadColumn.Name = "Cantidad"; // Asignar un nombre a la columna
                            dwvProductos.Columns.Add(cantidadColumn);


                            // Columna de botón "Agregar al carrito"
                            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
                            addButtonColumn.HeaderText = "Agregar al carrito";
                            addButtonColumn.Text = "Agregar";
                            addButtonColumn.Name = "btnAgregar";
                            addButtonColumn.UseColumnTextForButtonValue = true;
                            dwvProductos.Columns.Add(addButtonColumn);
                        }
                        // Llenar filas y cargar imágenes desde la url
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string imageUrl = row["imagen"].ToString();  // URL de la imagen desde la base de datos

                            Image img = null;

                            try
                            {
                                // Usar WebClient para descargar la imagen desde la URL
                                using (WebClient client = new WebClient())
                                {
                                    byte[] imageBytes = client.DownloadData(imageUrl);  // Descargar la imagen como un array de bytes
                                    using (MemoryStream stream = new MemoryStream(imageBytes))
                                    {
                                        img = Image.FromStream(stream);  // Convertir el array de bytes en una imagen
                                    }
                                }
                            }
                            catch
                            {
                                // Si ocurre un error al descargar la imagen, usar una imagen predeterminada
                                img = Image.FromFile("img\\default.png");
                            }

                            dwvProductos.Rows.Add(row["id"], img, row["descripcion"], row["precio"], row["existencia"]);
                        }

                        // Configuración de altura de filas e imágenes
                        dwvProductos.RowTemplate.Height = 100;
                        dwvProductos.Columns["Imagen"].Width = 100;
                        dwvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dwvProductos.AllowUserToAddRows = false; // Elimina la última fila vacía

                        // Crear tarjetas dinámicamente para cada producto
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Crear un panel para la tarjeta
                            Panel card = new Panel();
                            card.Size = new Size(280, 300);
                            card.BorderStyle = BorderStyle.FixedSingle;
                            card.Margin = new Padding(10);
                            card.BackColor = Color.LightCyan;

                            // Cargar la imagen del producto
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Size = new Size(150, 100);
                            pictureBox.Location = new Point(50, 10);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                            try
                            {
                                using (WebClient client = new WebClient())
                                {
                                    byte[] imageBytes = client.DownloadData(row["imagen"].ToString());
                                    using (MemoryStream stream = new MemoryStream(imageBytes))
                                    {
                                        pictureBox.Image = Image.FromStream(stream);
                                    }
                                }
                            }
                            catch
                            {
                                pictureBox.Image = Image.FromFile("img\\default.png");
                            }



                            // Etiqueta para el ID
                            Label lblId = new Label
                            {
                                Text = "ID: " + row["id"].ToString(),
                                ForeColor = Color.Black,
                                Location = new Point(10, 120),
                                AutoSize = true
                            };

                            // Etiqueta para la descripción
                            Label lblDescripcion = new Label
                            {
                                Text = "Descripción: " + row["descripcion"].ToString(),
                                Location = new Point(10, 150),
                                ForeColor = Color.Black,
                                AutoSize = true
                            };

                            // Etiqueta para el precio
                            Label lblPrecio = new Label
                            {
                                Text = "Precio: $" + row["precio"].ToString(),
                                Location = new Point(10, 180),
                                ForeColor = Color.Black,
                                AutoSize = true
                            };

                            // Etiqueta para la existencia
                            Label lblExistencia = new Label
                            {
                                Text = "Existencia: " + row["existencia"].ToString(),
                                ForeColor = Color.Black,
                                Location = new Point(10, 210),
                                AutoSize = true
                            };

                            // Caja de texto para cantidad
                            TextBox txtCantidad = new TextBox
                            {
                                PlaceholderText = "Cantidad",
                                Location = new Point(10, 240),
                                ForeColor = Color.Black,

                                Width = 50
                            };

                            // Botón para agregar al carrito
                            Button btnAgregar = new Button
                            {
                                Text = "Agregar al carrito",
                                Location = new Point(100, 240),
                                ForeColor = Color.Black,
                                AutoSize = true
                            };

                            // Evento para el botón
                            btnAgregar.Click += (sender, e) =>
                            {
                                int cantidad;
                                if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
                                {
                                    MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                int existencia = Convert.ToInt32(row["existencia"]);
                                if (cantidad > existencia)
                                {
                                    MessageBox.Show("No hay suficientes existencias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                AgregarAlCarrito(Convert.ToInt32(row["id"]), cantidad);
                                MessageBox.Show("Producto agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            };

                            if (tipoUsuario != "usuario")
                            {
                                txtCantidad.Visible = false;
                                btnAgregar.Visible = false;
                            };

                            // Agregar controles a la tarjeta (panel)
                            card.Controls.Add(pictureBox);
                            card.Controls.Add(lblId);
                            card.Controls.Add(lblDescripcion);
                            card.Controls.Add(lblPrecio);
                            card.Controls.Add(lblExistencia);
                            card.Controls.Add(txtCantidad);
                            card.Controls.Add(btnAgregar);

                            // Agregar tarjeta al FlowLayoutPanel
                            flowLayoutPanel1.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar la imagen desde un enlace URL
        private Image CargarImagenDesdeURL(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageBytes = webClient.DownloadData(url); // Descargar la imagen como un arreglo de bytes
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(memoryStream); // Convertir el arreglo de bytes a una imagen
                }
            }
        }
        private void dwvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que no es el encabezado ni una celda inválida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verifica si la columna es el botón
                if (dwvProductos.Columns[e.ColumnIndex].Name == "btnAgregar")
                {
                    // Obtener datos del producto
                    int idProducto = Convert.ToInt32(dwvProductos.Rows[e.RowIndex].Cells["ID"].Value);
                    int cantidad;
                    bool cantidadValida = Int32.TryParse(dwvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString(), out cantidad);

                    // Si la cantidad no es válida, mostrar un mensaje y salir
                    if (!cantidadValida || cantidad <= 0)
                    {
                        MessageBox.Show("Por favor, ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtener existencias del producto
                    int existencia = Convert.ToInt32(dwvProductos.Rows[e.RowIndex].Cells["Existencia"].Value);

                    // Validar si hay suficientes existencias
                    if (cantidad > existencia)
                    {
                        MessageBox.Show("No hay suficientes existencias del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Si las existencias son suficientes, agregar al carrito
                    AgregarAlCarrito(idProducto, cantidad);

                    // Mostrar mensaje de éxito
                    MessageBox.Show($"Producto agregado al carrito:\nID: {idProducto}\nCantidad: {cantidad}", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        /*Agregamos al carrito y restamos las existencias********************************************************************************************/
        /*********************************************************************************************/


        private void AgregarAlCarrito(int idProducto, int cantidad)
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta para insertar o actualizar en la tabla carrito
            string queryCarrito = @"
        INSERT INTO carrito (id, unidades) 
        VALUES (@id, @unidades)
        ON DUPLICATE KEY UPDATE unidades = unidades + @unidades";

            // Consulta para restar las existencias en la tabla productotienda
            string queryExistencias = @"
        UPDATE productotienda
        SET existencia = existencia - @unidades
        WHERE id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Iniciar una transacción para garantizar que ambas operaciones sean atómicas
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Ejecutar la consulta para insertar o actualizar el carrito
                            using (MySqlCommand cmd = new MySqlCommand(queryCarrito, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", idProducto);
                                cmd.Parameters.AddWithValue("@unidades", cantidad);
                                cmd.ExecuteNonQuery();
                            }

                            // Ejecutar la consulta para restar las existencias en la tabla productotienda
                            using (MySqlCommand cmdExistencias = new MySqlCommand(queryExistencias, connection, transaction))
                            {
                                cmdExistencias.Parameters.AddWithValue("@id", idProducto);
                                cmdExistencias.Parameters.AddWithValue("@unidades", cantidad);
                                cmdExistencias.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, revertir la transacción
                            transaction.Rollback();
                            throw new Exception("Error al agregar al carrito y actualizar existencias: " + ex.Message);
                        }
                    }
                }

                MessageBox.Show("Producto agregado al carrito y existencias actualizadas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar al carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*********************************************************************************************/
        /*********************************************************************************************/

        private void Productos_Load(object sender, EventArgs e)
        {
            // Cargar los productos al cargar el formulario
            CargarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos_Load(sender, e);
        }
    }
}