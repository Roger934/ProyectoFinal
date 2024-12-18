namespace Gina.Forms
{
    partial class Bajas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            btnAceptar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtExistencia = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtImagen = new TextBox();
            label2 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(38, 49);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 23;
            label6.Text = "Bajas";
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(134, 161);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtId
            // 
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(109, 100);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 100);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 12;
            label1.Text = "Id:";
            // 
            // txtExistencia
            // 
            txtExistencia.Enabled = false;
            txtExistencia.ForeColor = Color.Black;
            txtExistencia.Location = new Point(109, 344);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.ReadOnly = true;
            txtExistencia.Size = new Size(100, 23);
            txtExistencia.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(38, 347);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 41;
            label5.Text = "Existencia: ";
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(109, 300);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(38, 303);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 39;
            label4.Text = "Precio: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(109, 256);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 259);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 37;
            label3.Text = "Descipcion:";
            // 
            // txtImagen
            // 
            txtImagen.Enabled = false;
            txtImagen.ForeColor = Color.Black;
            txtImagen.Location = new Point(109, 215);
            txtImagen.Name = "txtImagen";
            txtImagen.ReadOnly = true;
            txtImagen.Size = new Size(100, 23);
            txtImagen.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 215);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 35;
            label2.Text = "Imagen: ";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(38, 161);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 43;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Bajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtExistencia);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtImagen);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(btnAceptar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Bajas";
            Text = "Bajas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnAceptar;
        private TextBox txtId;
        private Label label1;
        private TextBox txtExistencia;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtImagen;
        private Label label2;
        private Button btnBuscar;
    }
}