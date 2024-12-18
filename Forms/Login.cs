using System;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Gina.Forms
{
    public partial class Login : Form
    {
        public string tipoUsuario { get; private set; }
        public bool LoginExitoso { get; private set; }
        public string IdUsuario { get; private set; }

        public Login()
        {
            InitializeComponent();
            LoginExitoso = false; // Inicializa en falso
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string idUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContra.Text.Trim();
            IdUsuario = idUsuario;
            tipoUsuario = idUsuario;


            // Validar campos vacíos
            if (string.IsNullOrEmpty(idUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingresa el usuario y la contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cadena de conexión a MySQL en XAMPP
            string connectionString = "Server=localhost;Database=deportes;Uid=root;Pwd=;";

            // Consulta SQL
            string query = "SELECT COUNT(*) FROM registrosusuarios WHERE id = @id AND contrasena = @contrasena";

            try
            {
                // Crear conexión con MySQL
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // Abrir conexión

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Agregar parámetros para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        // Ejecutar la consulta
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Validar si las credenciales son correctas

                        if ( IdUsuario == "1") //condicional para que si loges como usuario no puedas acceder a admin (no se me ocurrio nada)
                        {
                            if (count > 0)
                            {
                                MessageBox.Show("¡Inicio de sesión como administrador exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginExitoso = true; // Marcar el login como exitoso
                                tipoUsuario = "1";
                                this.Hide(); // Ocultar el formulario actual
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LoginExitoso = false; // Mantener en falso
                            }
                            
                        }
                        else if (IdUsuario == "0") //condicional para que si loges como usuario no puedas acceder a admin (no se me ocurrio nada)
                        {
                            if (count > 0)
                            {
                                MessageBox.Show("¡Inicio de sesión como invitado exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginExitoso = true; // Marcar el login como exitoso
                                tipoUsuario = "0";
                                this.Hide(); // Ocultar el formulario actual
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LoginExitoso = false; // Mantener en falso
                            }

                        }
                        else
                        {
                            if (count > 0)
                            {
                                MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginExitoso = true; // Marcar el login como exitoso
                                tipoUsuario = "usuario";
                                this.Hide(); // Ocultar el formulario actual
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LoginExitoso = false; // Mantener en falso
                            }
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
