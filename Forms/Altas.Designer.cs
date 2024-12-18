namespace Gina.Forms
{
    partial class Altas
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
            label1 = new Label();
            txtId = new TextBox();
            txtImagen = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtExistencia = new TextBox();
            label5 = new Label();
            btnAceptar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.ForeColor = Color.Black;
            txtId.Location = new Point(170, 103);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 31);
            txtId.TabIndex = 1;
            // 
            // txtImagen
            // 
            txtImagen.ForeColor = Color.Black;
            txtImagen.Location = new Point(170, 177);
            txtImagen.Margin = new Padding(4, 5, 4, 5);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(141, 31);
            txtImagen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Imagen: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(170, 245);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(141, 31);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 4;
            label3.Text = "Descipcion:";
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(170, 318);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(141, 31);
            txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 323);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 6;
            label4.Text = "Precio: ";
            // 
            // txtExistencia
            // 
            txtExistencia.ForeColor = Color.Black;
            txtExistencia.Location = new Point(170, 392);
            txtExistencia.Margin = new Padding(4, 5, 4, 5);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(141, 31);
            txtExistencia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(69, 397);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 8;
            label5.Text = "Existencia: ";
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(206, 488);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(69, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 11;
            label6.Text = "Altas";
            // 
            // Altas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label6);
            Controls.Add(btnAceptar);
            Controls.Add(txtExistencia);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtImagen);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Altas";
            Text = "Altas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtImagen;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtExistencia;
        private Label label5;
        private Button btnAceptar;
        private Label label6;
    }
}