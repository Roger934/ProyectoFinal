using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Agregado para la conexión a la base de datos

namespace Gina.Forms
{
    public partial class FormPagoEfectivo : Form
    {
        private Label etiquetaMontoTotal;
        private Label etiquetaMontoPagado;
        private Label etiquetaCambio;
        private TextBox textoMontoPagado;
        private Label lblMontoTotal;
        private Label lblCambio;
        private Button botonPagar;
        private Button botonRegresar;

        private decimal montoTotal;
        private int usuarioId; // Para almacenar el ID del usuario

        public FormPagoEfectivo(int id, decimal monto)
        {
            usuarioId = id;
            montoTotal = monto;

            InitializeComponent();

            // Configuración del formulario de pago en efectivo
            Text = "Formulario de Pago en Efectivo";
            Width = 400;
            Height = 300;

            // Etiqueta para el monto total
            etiquetaMontoTotal = new Label
            {
                Text = "Monto Total a Pagar:",
                Top = 30,
                Left = 20,
                Width = 150
            };
            lblMontoTotal = new Label
            {
                Text = monto.ToString("C2"),
                Top = 30,
                Left = 180,
                Width = 150
            };

            // Etiqueta para el monto pagado
            etiquetaMontoPagado = new Label
            {
                Text = "Monto Pagado:",
                Top = 80,
                Left = 20,
                Width = 150
            };
            textoMontoPagado = new TextBox
            {
                Top = 80,
                Left = 180,
                Width = 150
            };

            // Etiqueta para el cambio
            etiquetaCambio = new Label
            {
                Text = "Cambio a Devolver:",
                Top = 130,
                Left = 20,
                Width = 150
            };
            lblCambio = new Label
            {
                Text = "$0.00",
                Top = 130,
                Left = 180,
                Width = 150
            };

            // Botón para procesar el pago
            botonPagar = new Button
            {
                Text = "Pagar",
                Top = 180,
                Left = 50,
                Width = 100
            };
            botonPagar.Click += BotonPagar_Click;

            // Botón para regresar
            botonRegresar = new Button
            {
                Text = "Regresar",
                Top = 180,
                Left = 200,
                Width = 100
            };
            botonRegresar.Click += BotonRegresar_Click;

            // Agregar controles al formulario
            Controls.Add(etiquetaMontoTotal);
            Controls.Add(lblMontoTotal);
            Controls.Add(etiquetaMontoPagado);
            Controls.Add(textoMontoPagado);
            Controls.Add(etiquetaCambio);
            Controls.Add(lblCambio);
            Controls.Add(botonPagar);
            Controls.Add(botonRegresar);
        }

        private void BotonPagar_Click(object sender, EventArgs e)
        {
            // Validar que el monto pagado sea válido
            decimal montoPagado;
            if (!decimal.TryParse(textoMontoPagado.Text, out montoPagado) || montoPagado < montoTotal)
            {
                MessageBox.Show("El monto pagado debe ser mayor o igual al monto total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el cambio
            decimal cambio = montoPagado - montoTotal;

            // Mostrar el cambio en el label
            lblCambio.Text = cambio.ToString("C2");

            // Actualizar el monto del usuario en la base de datos
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";
            string updateQuery = "UPDATE registrosusuarios SET monto = monto + @monto WHERE id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@monto", montoTotal);
                        cmd.Parameters.AddWithValue("@id", usuarioId);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Mostrar éxito
                MessageBox.Show($"Pago exitoso. El cambio es {cambio:C2}", "Pago Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Configuramos el DialogResult a OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            // Configuramos el DialogResult a Cancel para que se detecte como "cancelado"
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormPagoEfectivo_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío o usarse para inicializaciones adicionales si se necesita.
        }
    }
}