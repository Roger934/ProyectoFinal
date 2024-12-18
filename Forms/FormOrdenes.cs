using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gina.Models;
using PdfSharp.Drawing;

using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Gina.Forms
{
    public partial class Ordenes : Form
    {
        private List<Producto> carrito = new List<Producto>(); // Lista para almacenar productos
        public List<Pedidos> listaPedidos = new List<Pedidos>();
        public string idRecibido;
        public Ordenes(string idRecibido)
        {
            InitializeComponent();
            CargarCarrito(); // Cargar datos del carrito al iniciar
            this.idRecibido = idRecibido;
        }

        /// <summary>
        /// Carga los productos del carrito desde la base de datos.
        /// </summary>
        private void CargarCarrito()
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string query = @"
        SELECT c.numProducto, c.id, p.descripcion, p.precio, c.unidades
        FROM carrito c
        INNER JOIN productotienda p ON c.id = p.id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        carrito.Clear(); // Limpiar lista antes de cargar

                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = Convert.ToInt32(reader["numProducto"]), // numProducto
                                Descripcion = reader["descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["precio"]),
                                Existencia = Convert.ToInt32(reader["unidades"])
                            };
                            carrito.Add(producto);
                        }
                    }
                }

                // Mostrar solo las columnas necesarias en el DataGridView
                dgvOrdenes.DataSource = null;
                dgvOrdenes.DataSource = carrito;

                dgvOrdenes.Columns["Id"].HeaderText = "Número de Producto";
                dgvOrdenes.Columns["Descripcion"].HeaderText = "Descripción";
                dgvOrdenes.Columns["Precio"].HeaderText = "Precio";
                dgvOrdenes.Columns["Existencia"].HeaderText = "Unidades";

                // Opcional: Ocultar la columna Imagen si existiera
                if (dgvOrdenes.Columns["Imagen"] != null)
                    dgvOrdenes.Columns["Imagen"].Visible = false;

                CalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// Muestra los productos cargados en el DataGridView.
        /// </summary>
        private void MostrarEnDataGridView()
        {
            dgvOrdenes.DataSource = null; // Reiniciar la fuente de datos
            dgvOrdenes.DataSource = carrito;

            // Opcional: Ocultar la columna "Id"
            if (dgvOrdenes.Columns["Id"] != null)
                dgvOrdenes.Columns["Id"].Visible = false;

            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Calcula el monto total, IVA y total a pagar del carrito.
        /// </summary>
        private void CalcularTotales()
        {
            decimal montoTotal = 0m;

            foreach (var producto in carrito)
            {
                montoTotal += producto.Precio * producto.Existencia;
            }

            decimal iva = montoTotal * 0.06m;
            decimal totalPagar = montoTotal + iva;

            // Mostrar los resultados en los labels
            lblMonto.Text = montoTotal.ToString("C");
            lbliva.Text = iva.ToString("C");
            lblTotal.Text = totalPagar.ToString("C");
            lblid.Text = totalPagar.ToString();

            if (carrito.Count == 0)
            {
                lblMonto.Text = "0.00";
                lbliva.Text = "0.00";
                lblTotal.Text = "0.00";
            }
        }

        /// <summary>
        /// Evento al hacer clic en el botón de pagar.
        /// </summary>
        /// <summary>
        /// Evento al hacer clic en el botón de pagar.
        /// </summary>
        /// <summary>
        /// Evento al hacer clic en el botón de pagar.
        /// </summary>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el monto total desde lblTotal, eliminando símbolos de moneda
            string montoTotalStr = lblTotal.Text.Trim().Replace("$", "").Replace("€", "").Replace(",", "");
            decimal montoTotal = 0m;

            if (decimal.TryParse(montoTotalStr, out montoTotal))
            {
                try
                {
                    // Generar QR independiente
                    GenerarQR(montoTotal);

                    // Generar PDF independiente
                    GenerarPDF_iTextSharp(carrito, montoTotal);

                    // Actualizar monto en la base de datos
                    string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
                    string updateQuery = "UPDATE registrosusuarios SET monto = monto + @monto WHERE id = @id";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@monto", montoTotal);
                            cmd.Parameters.AddWithValue("@id", idRecibido);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Pago realizado con éxito. El QR y el PDF han sido generados.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCarrito();
                    ActualizarExistencias();
                    // Limpiar carrito después del pago
                    LimpiarCarrito();
                    BorrarCarrito();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El monto total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Genera un código QR y lo guarda como imagen en el escritorio.
        /// </summary>
        private void GenerarQR(decimal montoTotal)
        {
            try
            {
                // Ruta donde se guardará el QR
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string qrPath = Path.Combine(desktopPath, "QRCode.png");

                // Contenido del QR
                string qrContenido = $"Pago realizado.\nTotal: {montoTotal:C}.\nFecha: {DateTime.Now}";

                using (var qrGenerator = new QRCoder.QRCodeGenerator())
                using (var qrCodeData = qrGenerator.CreateQrCode(qrContenido, QRCoder.QRCodeGenerator.ECCLevel.Q))
                using (var qrCode = new QRCoder.QRCode(qrCodeData))
                using (var qrImage = qrCode.GetGraphic(20))
                {
                    qrImage.Save(qrPath, System.Drawing.Imaging.ImageFormat.Png);
                }

                MessageBox.Show($"QR generado correctamente en: {qrPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el QR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Genera un PDF con los datos del carrito y el monto total.
        /// </summary>
        /// <summary>
        /// Genera un PDF con los datos del carrito y el monto total.
        /// </summary>
        public void GenerarPDF_iTextSharp(List<Producto> carrito, decimal montoTotal)
        {
            try
            {
                // Ruta donde se guardará el PDF en el escritorio
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string pdfPath = Path.Combine(desktopPath, "ReciboDePago_iTextSharp.pdf");

                // Crear el documento PDF
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

                // Abrir el documento
                document.Open();

                // Cargar el logo desde la carpeta "img" del proyecto
                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "logo.png");

                // Crear una tabla para colocar el logo y el texto juntos
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.WidthPercentage = 100;
                headerTable.SetWidths(new float[] { 20f, 80f }); // Tamaño relativo de columnas: logo - texto

                // Celda del logo
                if (File.Exists(logoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(80, 80); // Escalar el logo
                    PdfPCell logoCell = new PdfPCell(logo)
                    {
                     
                        HorizontalAlignment = Element.ALIGN_LEFT,
                        VerticalAlignment = Element.ALIGN_MIDDLE
                    };
                    headerTable.AddCell(logoCell);
                }
                else
                {
                    MessageBox.Show("El archivo del logo no fue encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Celda del texto (eslogan y nombre de la tienda)
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);

                PdfPCell textCell = new PdfPCell();
           
                textCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                Paragraph nombreTienda = new Paragraph("DN Deport", boldFont); // Nombre de la tienda
                nombreTienda.Alignment = Element.ALIGN_LEFT;

                Paragraph eslogan = new Paragraph("Aquí te equipamos, la condición ya es tu bronca", normalFont); // Eslogan
                eslogan.Alignment = Element.ALIGN_LEFT;

                textCell.AddElement(nombreTienda);
                textCell.AddElement(eslogan);

                headerTable.AddCell(textCell);

                // Agregar la tabla (logo y texto) al documento
                document.Add(headerTable);

                // Agregar un espacio
                document.Add(new Paragraph(" "));

                // Agregar título
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                document.Add(new Paragraph("Recibo de Pago", titleFont));
                document.Add(new Paragraph(" "));

                // Agregar fecha
                document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", normalFont));

                document.Add(new Paragraph(" "));

                // Tabla con los productos del carrito
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 15f, 35f, 15f, 15f, 20f });

                // Encabezados de la tabla
                table.AddCell(new PdfPCell(new Phrase("Num Producto", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Descripción", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Precio", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Unidades", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Subtotal", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });

                // Contenido de la tabla
                foreach (var producto in carrito)
                {
                    table.AddCell(new PdfPCell(new Phrase(producto.Id.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(producto.Descripcion, normalFont)));
                    table.AddCell(new PdfPCell(new Phrase($"${producto.Precio:F2}", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(producto.Existencia.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase($"${(producto.Precio * producto.Existencia):F2}", normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                }

                // Agregar la tabla al documento
                document.Add(table);
                document.Add(new Paragraph(" "));

                // Calcular el IVA y el total
                decimal iva = montoTotal * 0.06m;
                decimal totalPagar = montoTotal - iva;

                // Mostrar totales
                document.Add(new Paragraph($"Monto: ${totalPagar:F2}", normalFont));
                document.Add(new Paragraph($"IVA (6%): ${iva:F2}", normalFont));
                document.Add(new Paragraph($"Total a Pagar: ${montoTotal:F2}", normalFont));

                // Cerrar el documento
                document.Close();

                // Notificación de éxito
                MessageBox.Show($"PDF generado exitosamente en: {pdfPath}", "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /***************************************************************************************************************************************/
        private void CancelarCompra()
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string selectQuery = "SELECT id, unidades FROM carrito"; // Para obtener las unidades en el carrito
            string updateQuery = @"
                UPDATE productotienda
                SET existencia = existencia + @unidades
                WHERE id = @id"; // Para actualizar las existencias

            string deleteQuery = "DELETE FROM carrito"; // Para vaciar el carrito

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
                            // 1. Obtener las unidades del carrito para cada producto
                            List<Tuple<int, int>> carritoItems = new List<Tuple<int, int>>();

                            using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection, transaction))
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int idProducto = Convert.ToInt32(reader["id"]);
                                    int unidades = Convert.ToInt32(reader["unidades"]);
                                    carritoItems.Add(new Tuple<int, int>(idProducto, unidades));
                                }
                            }

                            // 2. Actualizar las existencias en la tabla productotienda
                            foreach (var item in carritoItems)
                            {
                                int idProducto = item.Item1;
                                int unidades = item.Item2;

                                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, connection, transaction))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@id", idProducto);
                                    cmdUpdate.Parameters.AddWithValue("@unidades", unidades);

                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }

                            // 3. Eliminar los productos del carrito
                            using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, connection, transaction))
                            {
                                cmdDelete.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();

                            // Limpiar lista local y actualizar el DataGridView
                            carrito.Clear();
                            dgvOrdenes.DataSource = null;

                            // Restablecer los labels a cero
                            lblMonto.Text = "0.00";
                            lbliva.Text = "0.00";
                            lblTotal.Text = "0.00";

                            MessageBox.Show("La compra ha sido cancelada, los productos han sido devueltos al inventario y el carrito está vacío.", "Compra Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, revertir la transacción
                            transaction.Rollback();
                            MessageBox.Show($"Error al cancelar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza las existencias de los productos en la base de datos después de realizar un pago.
        /// </summary>
        /// <summary>
        /// Actualiza las existencias de los productos en la base de datos después de realizar un pago.
        /// </summary>


        /// <summary>
        /// Limpia el carrito después de realizar un pago.
        /// </summary>
        private void LimpiarCarrito()
        {
            carrito.Clear();
            MostrarEnDataGridView();
            CalcularTotales();
        }

        private void btnCancelarcompra_Click(object sender, EventArgs e)
        {
            CancelarCompra();
        }

        private void btnPagarE_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string montoTotalStr = lblTotal.Text.Trim().Replace("$", "").Replace("€", "").Replace(",", "");
            if (decimal.TryParse(montoTotalStr, out decimal montoTotal))
            {
                if (int.TryParse(idRecibido, out int idUsuario))
                {
                    FormPagoEfectivo formPagoEfectivo = new FormPagoEfectivo(idUsuario, montoTotal);

                    // Mostrar formulario y verificar si se acepta el pago
                    if (formPagoEfectivo.ShowDialog() == DialogResult.OK)
                    {
                        GenerarPDF_iTextSharp(carrito, montoTotal); // Genera el PDF solo si se confirma
                        MessageBox.Show("Pago en efectivo realizado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCarrito(); // Limpia el carrito únicamente si el pago fue exitoso
                        BorrarCarrito();
                    }
                    else
                    {
                        MessageBox.Show("El pago en efectivo fue cancelado.", "Pago Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El ID del usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El monto total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string montoTotalStr = lblTotal.Text.Trim().Replace("$", "").Replace("€", "").Replace(",", "");
            if (decimal.TryParse(montoTotalStr, out decimal montoTotal))
            {
                if (int.TryParse(idRecibido, out int idUsuario))
                {
                    FormPagoTarjeta formPagoTarjeta = new FormPagoTarjeta(idUsuario, montoTotal);

                    // Mostrar formulario y verificar si el pago es aceptado
                    if (formPagoTarjeta.ShowDialog() == DialogResult.OK)
                    {
                        GenerarPDF_iTextSharp(carrito, montoTotal); // Genera el PDF solo si se confirma
                        MessageBox.Show("Pago con tarjeta realizado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCarrito(); // Limpia el carrito únicamente si el pago fue exitoso
                        BorrarCarrito();
                    }
                    else
                    {
                        MessageBox.Show("El pago con tarjeta fue cancelado.", "Pago Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El ID del usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El monto total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BorrarCarrito()
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string deleteQuery = "DELETE FROM carrito";

            try
            {
                // Conexión a la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.ExecuteNonQuery(); // Ejecutar la consulta de borrado
                    }
                }

                // Limpiar lista local del carrito
                carrito.Clear();
                dgvOrdenes.DataSource = null;

                // Restablecer los totales a cero
                lblMonto.Text = "0.00";
                lbliva.Text = "0.00";
                lblTotal.Text = "0.00";

                MessageBox.Show("El carrito ha sido borrado correctamente.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar el carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para guardar los datos de la tabla carrito
        private void CargarPedidosDesdeCarrito() // guarda los prodctos encargados en una lista para despues actualizarlos
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string query = @"
            SELECT c.numProducto, c.id, c.unidades
            FROM carrito c";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaPedidos.Clear(); // Limpiar lista antes de cargar

                        while (reader.Read())
                        {
                            Pedidos pedido = new Pedidos
                            {
                                idProducto = Convert.ToInt32(reader["id"]), // Segundo campo: id
                                Unidades = Convert.ToInt32(reader["unidades"]) // Tercer campo: unidades
                            };

                            listaPedidos.Add(pedido); // Agregar pedido a la lista
                        }
                    }
                }

                MessageBox.Show("Datos cargados correctamente desde la tabla carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarExistencias()
        {
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Recorremos la lista de pedidos
                    foreach (var pedido in listaPedidos)
                    {
                        // Declaración de variables locales
                        int id = pedido.idProducto; // Obtener el idProducto del pedido
                        int unidades = pedido.Unidades; // Obtener las unidades del pedido
                        int existenciasActuales = 0; // Variable para almacenar las existencias actuales

                        // Consultar las existencias actuales del producto en la tabla productotienda
                        string queryExistencias = @"
                        SELECT existencia
                        FROM productotienda
                        WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(queryExistencias, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id); // Asignar el parámetro id

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Verificar si se obtuvo un resultado
                                {
                                    existenciasActuales = Convert.ToInt32(reader["existencia"]); // Guardar las existencias actuales
                                }
                                else
                                {
                                    Console.WriteLine($"El producto con ID {id} no tiene existencias registradas.");
                                    continue; // Pasar al siguiente pedido si no se encuentra el producto
                                }
                            }
                        }

                        // Restar las unidades de las existencias actuales
                        int nuevasExistencias = existenciasActuales - unidades;

                        // Actualizar las existencias en la tabla productotienda
                        string updateQuery = @"
                        UPDATE productotienda
                        SET existencia = @nuevasExistencias
                        WHERE id = @id";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                        {
                            // Asignar los parámetros para el UPDATE
                            updateCmd.Parameters.AddWithValue("@nuevasExistencias", nuevasExistencias);
                            updateCmd.Parameters.AddWithValue("@id", id);

                            // Ejecutar el UPDATE
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            // Verificar si la consulta afectó alguna fila
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Existencias actualizadas para el producto con ID {id}. Nuevas existencias: {nuevasExistencias}");
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró el producto con ID {id} o no se pudo actualizar.");
                            }
                        }
                    }
                }

                MessageBox.Show("Las existencias se han actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar las existencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

