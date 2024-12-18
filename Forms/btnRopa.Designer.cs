namespace Gina.Forms
{
    partial class btnRopa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblDesc = new Label();
            lblPrecio = new Label();
            lblExist = new Label();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblId = new Label();
            pictureBox1 = new PictureBox();
            txtBoxCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            lblCantidad = new Label();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Location = new Point(247, 72);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(78, 25);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Location = new Point(247, 112);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblExist
            // 
            lblExist.AutoSize = true;
            lblExist.BackColor = Color.Transparent;
            lblExist.Location = new Point(247, 150);
            lblExist.Name = "lblExist";
            lblExist.Size = new Size(95, 25);
            lblExist.TabIndex = 3;
            lblExist.Text = "Existencias";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.CustomizableEdges = customizableEdges1;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.FromArgb(255, 192, 192);
            guna2GradientButton1.FillColor2 = Color.FromArgb(192, 192, 255);
            guna2GradientButton1.Font = new Font("Segoe UI", 9F);
            guna2GradientButton1.ForeColor = Color.Black;
            guna2GradientButton1.Location = new Point(230, 297);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1.Size = new Size(270, 68);
            guna2GradientButton1.TabIndex = 4;
            guna2GradientButton1.Text = "Agregar al carrito";
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(lblCantidad);
            guna2GradientPanel1.Controls.Add(txtBoxCantidad);
            guna2GradientPanel1.Controls.Add(lblId);
            guna2GradientPanel1.Controls.Add(lblDesc);
            guna2GradientPanel1.Controls.Add(lblPrecio);
            guna2GradientPanel1.Controls.Add(lblExist);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(192, 255, 255);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(192, 255, 192);
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(518, 389);
            guna2GradientPanel1.TabIndex = 5;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Location = new Point(247, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 171);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtBoxCantidad
            // 
            txtBoxCantidad.CustomizableEdges = customizableEdges3;
            txtBoxCantidad.DefaultText = "";
            txtBoxCantidad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxCantidad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxCantidad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxCantidad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxCantidad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxCantidad.Font = new Font("Segoe UI", 9F);
            txtBoxCantidad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxCantidad.Location = new Point(247, 224);
            txtBoxCantidad.Margin = new Padding(4, 5, 4, 5);
            txtBoxCantidad.Name = "txtBoxCantidad";
            txtBoxCantidad.PasswordChar = '\0';
            txtBoxCantidad.PlaceholderText = "";
            txtBoxCantidad.SelectedText = "";
            txtBoxCantidad.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBoxCantidad.Size = new Size(204, 41);
            txtBoxCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Location = new Point(247, 194);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(87, 25);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnRopa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2GradientButton1);
            Controls.Add(guna2GradientPanel1);
            Name = "btnRopa";
            Size = new Size(518, 389);
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblDesc;
        private Label lblPrecio;
        private Label lblExist;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private PictureBox pictureBox1;
        private Label lblId;
        private Label lblCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCantidad;
    }
}
