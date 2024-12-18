using Gina.Forms;
using System;
using System.Windows.Forms;

namespace Gina
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpia el contenido anterior del panel
            if (panel.Controls.Count > 0)
                panel.Controls.Clear();

            // Configura el formulario
            formulario.TopLevel = false; // No es formulario independiente
            formulario.Dock = DockStyle.Fill; // Ajusta al tamaño del Panel
            formulario.FormBorderStyle = FormBorderStyle.None; // Sin bordes

            // Agrega el formulario al Panel y muestra
            panel.Controls.Add(formulario);
            panel.Tag = formulario; // Referencia del formulario
            formulario.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            string tipo = loginForm.tipoUsuario;
            if (loginForm.LoginExitoso)
            {
                string idUsuario = loginForm.IdUsuario;
                FormMenu formMenu = new FormMenu(idUsuario, tipo);
                formMenu.Show();
                this.Hide();
            }
        }
    }
}
