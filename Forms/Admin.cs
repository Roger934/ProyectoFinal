using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gina.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpia el contenido anterior del panel
            if (panelProductos.Controls.Count > 0)
                panelProductos.Controls.Clear();

            // Configura el formulario
            formulario.TopLevel = false; // No es formulario independiente
            formulario.Dock = DockStyle.Fill; // Ajusta al tamaño del Panel
            formulario.FormBorderStyle = FormBorderStyle.None; // Sin bordes

            // Agrega el formulario al Panel y muestra
            panelProductos.Controls.Add(formulario);
            panelProductos.Tag = formulario; // Referencia del formulario
            formulario.Show();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            Altas altas = new Altas();
            AbrirFormularioEnPanel(altas);
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            Bajas bajas = new Bajas();
            AbrirFormularioEnPanel(bajas);
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            Cambios cambios = new Cambios();
            AbrirFormularioEnPanel(cambios);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            AbrirFormularioEnPanel(consultas);
        }

        // Método para cargar los datos en el DataGridView
        private void CargarProductos()
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL para obtener todos los productos
            string query = "SELECT id, imagen, descripcion, precio, existencia FROM productotienda";

            try
            {
                // Crear una conexión a la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Abrir la conexión

                    // Crear el comando SQL
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Crear un adaptador para llenar el DataTable
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                        // Crear un DataTable para almacenar los resultados de la consulta
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los resultados de la consulta
                        dataAdapter.Fill(dataTable);

                        // Comprobar si hay datos antes de asignar al DataGridView
                        if (dataTable.Rows.Count > 0)
                        {
                            // Enlazar el DataTable al DataGridView
                            dgvBase.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron productos en la base de datos.", "Sin Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void Productos_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar los productos al cargar el formulario
            CargarProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Productos_Load(sender, e);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormsVentas ventas = new FormsVentas();
            AbrirFormularioEnPanel(ventas);
        }

        private void dgvBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
