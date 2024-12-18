namespace Gina.Forms
{
    partial class Admin
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
            btnAltas = new Button();
            btnBajas = new Button();
            btnCambios = new Button();
            dgvBase = new DataGridView();
            panelProductos = new Panel();
            groupBox = new GroupBox();
            btnVentas = new Button();
            btnConsultas = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBase).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnAltas
            // 
            btnAltas.ForeColor = Color.Black;
            btnAltas.Location = new Point(52, 56);
            btnAltas.Margin = new Padding(4, 5, 4, 5);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(130, 50);
            btnAltas.TabIndex = 0;
            btnAltas.Text = "Altas";
            btnAltas.UseVisualStyleBackColor = true;
            btnAltas.Click += btnAltas_Click;
            // 
            // btnBajas
            // 
            btnBajas.ForeColor = Color.Black;
            btnBajas.Location = new Point(191, 56);
            btnBajas.Margin = new Padding(4, 5, 4, 5);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(111, 46);
            btnBajas.TabIndex = 1;
            btnBajas.Text = "Bajas";
            btnBajas.UseVisualStyleBackColor = true;
            btnBajas.Click += btnBajas_Click;
            // 
            // btnCambios
            // 
            btnCambios.ForeColor = Color.Black;
            btnCambios.Location = new Point(311, 56);
            btnCambios.Margin = new Padding(4, 5, 4, 5);
            btnCambios.Name = "btnCambios";
            btnCambios.Size = new Size(115, 45);
            btnCambios.TabIndex = 2;
            btnCambios.Text = "Cambios";
            btnCambios.UseVisualStyleBackColor = true;
            btnCambios.Click += btnCambios_Click;
            // 
            // dgvBase
            // 
            dgvBase.BackgroundColor = Color.Gray;
            dgvBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBase.GridColor = Color.DimGray;
            dgvBase.Location = new Point(18, 269);
            dgvBase.Margin = new Padding(4, 5, 4, 5);
            dgvBase.Name = "dgvBase";
            dgvBase.RowHeadersWidth = 51;
            dgvBase.Size = new Size(848, 495);
            dgvBase.TabIndex = 3;
            dgvBase.CellContentClick += dgvBase_CellContentClick;
            // 
            // panelProductos
            // 
            panelProductos.Location = new Point(71, 189);
            panelProductos.Margin = new Padding(4, 5, 4, 5);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(486, 694);
            panelProductos.TabIndex = 4;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnVentas);
            groupBox.Controls.Add(btnConsultas);
            groupBox.Controls.Add(panelProductos);
            groupBox.Controls.Add(btnAltas);
            groupBox.Controls.Add(btnCambios);
            groupBox.Controls.Add(btnBajas);
            groupBox.Location = new Point(888, 80);
            groupBox.Margin = new Padding(4, 5, 4, 5);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(4, 5, 4, 5);
            groupBox.Size = new Size(619, 891);
            groupBox.TabIndex = 5;
            groupBox.TabStop = false;
            // 
            // btnVentas
            // 
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(191, 124);
            btnVentas.Margin = new Padding(4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(235, 45);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Consultar ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.ForeColor = Color.Black;
            btnConsultas.Location = new Point(434, 56);
            btnConsultas.Margin = new Padding(4, 5, 4, 5);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(124, 46);
            btnConsultas.TabIndex = 5;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(699, 791);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 49);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 48);
            label1.TabIndex = 7;
            label1.Text = "Productos";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 1031);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(groupBox);
            Controls.Add(dgvBase);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvBase).EndInit();
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltas;
        private Button btnBajas;
        private Button btnCambios;
        private DataGridView dgvBase;
        private Panel panelProductos;
        private GroupBox groupBox;
        private Button btnConsultas;
        private Button btnActualizar;
        private Label label1;
        private Button btnVentas;
    }
}