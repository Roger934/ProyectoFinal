using System;
using System.Collections.Generic;
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
    public partial class FormPagoTarjeta : Form
    {
        private Label etiquetaNumeroTarjeta;
        private Label etiquetaNIP;
        private Label etiquetaNombreTitular;
        private Label etiquetaFechaCaducidad;
        private TextBox textoNumeroTarjeta;
        private TextBox textoNIP;
        private TextBox textoNombreTitular;
        private TextBox textoMesCaducidad;
        private TextBox textoAnioCaducidad;
        private Button botonPagar;
        private Button botonRegresar;

        private int usuarioId;
        private decimal montoPago;

        public FormPagoTarjeta(int id, decimal monto)
        {
            usuarioId = id;
            montoPago = monto;

            InitializeComponent();

            // Configuración del formulario de pago
            Text = "Formulario de Pago con Tarjeta";
            Width = 450;
            Height = 400;

            // Etiqueta y cuadro de texto para el número de tarjeta
            etiquetaNumeroTarjeta = new Label
            {
                Text = "Número de Tarjeta:",
                Top = 30,
                Left = 20,
                Width = 150
            };
            textoNumeroTarjeta = new TextBox
            {
                Top = 30,
                Left = 180,
                Width = 180
            };

            // Etiqueta y cuadro de texto para el NIP
            etiquetaNIP = new Label
            {
                Text = "NIP:",
                Top = 80,
                Left = 20,
                Width = 150
            };
            textoNIP = new TextBox
            {
                Top = 80,
                Left = 180,
                Width = 180,
                PasswordChar = '*'
            };

            // Etiqueta y cuadro de texto para el nombre del titular
            etiquetaNombreTitular = new Label
            {
                Text = "Nombre del Titular:",
                Top = 130,
                Left = 20,
                Width = 150
            };
            textoNombreTitular = new TextBox
            {
                Top = 130,
                Left = 180,
                Width = 180
            };

            // Etiqueta y cuadro de texto para la fecha de caducidad
            etiquetaFechaCaducidad = new Label
            {
                Text = "Fecha de Caducidad (MM/AA):",
                Top = 180,
                Left = 20,
                Width = 200
            };
            textoMesCaducidad = new TextBox
            {
                Top = 180,
                Left = 230,
                Width = 40
            };
            textoAnioCaducidad = new TextBox
            {
                Top = 180,
                Left = 280,
                Width = 40
            };

            // Botón para enviar
            botonPagar = new Button
            {
                Text = "Pagar",
                Top = 250,
                Left = 150,
                Width = 100
            };
            botonPagar.Click += BotonPagar_Click;

            // Botón para regresar
            botonRegresar = new Button
            {
                Text = "Regresar",
                Top = 250,
                Left = 270,
                Width = 100
            };
            botonRegresar.Click += BotonRegresar_Click;

            // Agregar controles al formulario
            Controls.Add(etiquetaNumeroTarjeta);
            Controls.Add(textoNumeroTarjeta);
            Controls.Add(etiquetaNIP);
            Controls.Add(textoNIP);
            Controls.Add(etiquetaNombreTitular);
            Controls.Add(textoNombreTitular);
            Controls.Add(etiquetaFechaCaducidad);
            Controls.Add(textoMesCaducidad);
            Controls.Add(textoAnioCaducidad);
            Controls.Add(botonPagar);
            Controls.Add(botonRegresar);
        }

        private void BotonPagar_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = textoNumeroTarjeta.Text.Trim();
            string nip = textoNIP.Text.Trim();
            string nombreTitular = textoNombreTitular.Text.Trim();
            string mesCaducidad = textoMesCaducidad.Text.Trim();
            string anioCaducidad = textoAnioCaducidad.Text.Trim();

            // Validar datos básicos
            if (numeroTarjeta.Length != 16)
            {
                MessageBox.Show("El número de tarjeta debe tener 16 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nip.Length != 3)
            {
                MessageBox.Show("El NIP debe tener 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(nombreTitular))
            {
                MessageBox.Show("El nombre del titular no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mesCaducidad.Length != 2 || !int.TryParse(mesCaducidad, out int mes) || mes < 1 || mes > 12)
            {
                MessageBox.Show("El mes de caducidad debe ser un número válido entre 01 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (anioCaducidad.Length != 2 || !int.TryParse(anioCaducidad, out int anio) || anio < 0)
            {
                MessageBox.Show("El año de caducidad debe ser un número válido de dos dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        cmd.Parameters.AddWithValue("@monto", montoPago);
                        cmd.Parameters.AddWithValue("@id", usuarioId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pago procesado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Configurar DialogResult a OK para indicar éxito
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
            // Configurar DialogResult a Cancel para regresar sin procesar el pago
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormPagoTarjeta_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío o usarse para inicializaciones adicionales si se necesita.
        }
    }
}
