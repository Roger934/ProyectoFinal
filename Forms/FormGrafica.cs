using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gina.Forms
{
    public partial class Grafica : Form
    {
        public Grafica()
        {
            InitializeComponent();
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL para obtener los montos de cada usuario
            string query = "SELECT id, monto FROM registrosusuarios";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpiar la gráfica
                            chart1.Series.Clear();
                            chart1.ChartAreas.Clear();

                            // Crear el área de la gráfica
                            ChartArea chartArea = new ChartArea();
                            chartArea.AxisX.Interval = 1; // Intervalo entre los valores del eje X
                            chart1.ChartAreas.Add(chartArea);

                            // Crear una nueva serie para la gráfica
                            Series series = new Series("Montos por Usuario")
                            {
                                ChartType = SeriesChartType.Column,
                                BorderWidth = 1,
                                IsValueShownAsLabel = true, // Mostrar los valores en las barras
                                CustomProperties = "PointWidth=0.8" // Ajusta el grosor de las barras
                            };
                            chart1.Series.Add(series);

                            // Lista para almacenar los montos y IDs de usuario
                            List<int> usuarioIds = new List<int>();
                            List<decimal> montos = new List<decimal>();

                            // Leer los datos y almacenarlos en las listas
                            while (reader.Read())
                            {
                                int usuarioId = reader.GetInt32("id");
                                decimal monto = reader.GetDecimal("monto");

                                usuarioIds.Add(usuarioId);
                                montos.Add(monto);
                            }

                            // Agregar los puntos al gráfico usando las listas
                            for (int i = 0; i < usuarioIds.Count; i++)
                            {
                                series.Points.AddXY(usuarioIds[i], montos[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación completada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}