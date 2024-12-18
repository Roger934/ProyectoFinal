using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gina.Forms
{
    public partial class btnRopa : UserControl
    {
        private int id = 0;
        private string descripcion = "Descripción del producto";
        public btnRopa()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Idd
        {
            get { return lblId.Text; }
            set { lblId.Text = value; }
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Image ImgProducto
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Precio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }

        }

        
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
