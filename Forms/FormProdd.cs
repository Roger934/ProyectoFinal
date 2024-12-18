using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;


namespace Gina.Forms
{
    public partial class FormProdd : Form
    {
        public FormProdd()
        {
            InitializeComponent();
        }



        private void LlenarProductos()
        {
            dbProductos obj = new dbProductos();
            obj.LlenarBotones(flowLayoutPanel1);
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            LlenarProductos();
        }
    }
}
