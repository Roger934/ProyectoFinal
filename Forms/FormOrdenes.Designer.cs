namespace Gina.Forms
{
    partial class Ordenes
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
            dgvOrdenes = new DataGridView();
            btnPagar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMonto = new Label();
            lbliva = new Label();
            lblTotal = new Label();
            label7 = new Label();
            btnCancelarcompra = new Button();
            lblid = new Label();
            btnPagarE = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(36, 101);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.Size = new Size(446, 296);
            dgvOrdenes.TabIndex = 0;
            // 
            // btnPagar
            // 
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(513, 284);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "Pago Oxxo";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(515, 142);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Monto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(515, 179);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "IVA(0.6%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(515, 100);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Compra actual";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = Color.Black;
            lblMonto.Location = new Point(635, 142);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(38, 15);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "label4";
            // 
            // lbliva
            // 
            lbliva.AutoSize = true;
            lbliva.ForeColor = Color.Black;
            lbliva.Location = new Point(635, 179);
            lbliva.Name = "lbliva";
            lbliva.Size = new Size(38, 15);
            lbliva.TabIndex = 6;
            lbliva.Text = "label5";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(635, 221);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(515, 221);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 8;
            label7.Text = "Total a pagar:";
            // 
            // btnCancelarcompra
            // 
            btnCancelarcompra.ForeColor = Color.Black;
            btnCancelarcompra.Location = new Point(513, 337);
            btnCancelarcompra.Name = "btnCancelarcompra";
            btnCancelarcompra.Size = new Size(145, 23);
            btnCancelarcompra.TabIndex = 9;
            btnCancelarcompra.Text = "Cancelar Compra";
            btnCancelarcompra.UseVisualStyleBackColor = true;
            btnCancelarcompra.Click += btnCancelarcompra_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(556, 41);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 15);
            lblid.TabIndex = 10;
            // 
            // btnPagarE
            // 
            btnPagarE.ForeColor = Color.Black;
            btnPagarE.Location = new Point(734, 284);
            btnPagarE.Name = "btnPagarE";
            btnPagarE.Size = new Size(116, 23);
            btnPagarE.TabIndex = 11;
            btnPagarE.Text = "Pago en efectivo";
            btnPagarE.UseVisualStyleBackColor = true;
            btnPagarE.Click += btnPagarE_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(610, 284);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 12;
            button2.Text = "Pago con tarjeta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 526);
            Controls.Add(button2);
            Controls.Add(btnPagarE);
            Controls.Add(lblid);
            Controls.Add(btnCancelarcompra);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(lbliva);
            Controls.Add(lblMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPagar);
            Controls.Add(dgvOrdenes);
            Margin = new Padding(2);
            Name = "Ordenes";
            Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrdenes;
        private Button btnPagar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        public Label lblMonto;
        public Label lbliva;
        public Label lblTotal;
        private Button btnCancelarcompra;
        private Label lblid;
        private Button btnPagarE;
        private Button button2;
    }
}