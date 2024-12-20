using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Gina.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;

namespace Gina
{
    public partial class FormMenu : Form
    {
        private string idRecibido;
        public string usuario;
        private string tipoUsuario;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMenu(string id, string tipo)
        {
            InitializeComponent();
            timer1.Start();
            idRecibido = id;
            usuario = tipo;

            if (usuario == "0")
            {
                txtUsu.Text = "Invitado";
            }
            else if (usuario == "1")
            {
                txtUsu.Text = "Admin";
            }
            else
            {
                txtUsu.Text = "Usuario " + id;
            }

            //MessageBox.Show("Tipo: " + usuario); Comprobar id

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (usuario == "0")
            {
                OrdenesButton.Visible = false;
            }
            if (usuario != "1")
            {
                adminbtn.Visible = false;
                graficButton.Visible = false;
            }
            if (usuario == "1")
            {
                OrdenesButton.Visible = false;
            }

        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //M�todos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(106, 113, 113);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                leftBorderBtn.BringToFront();
                //Icon Current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(106, 113, 113);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void OrdenesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Ordenes(idRecibido));
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Productos(usuario)); ////////////////////////

        }

        private void graficButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Grafica());

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Aqua;
            lbTitleChildForm.Text = "Home";

        }

        private void lbTitleChildForm_Click(object sender, EventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseW_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Admin());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer Sonido = new SoundPlayer();
            Sonido.SoundLocation = @"D:\C#\ProyectoPOO\song.wav";
            Sonido.Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            SoundPlayer Sonido = new SoundPlayer();
            Sonido.SoundLocation = @"D:\C#\ProyectoPOO\song.wav";
            Sonido.Stop();
        }

        
    }
}
