namespace Gina.Forms
{
    partial class Productos
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dwvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dwvProductos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1281, 98);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 1;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(44, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1086, 722);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // dwvProductos
            // 
            dwvProductos.AllowUserToAddRows = false;
            dwvProductos.AllowUserToDeleteRows = false;
            dwvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dwvProductos.Location = new Point(1137, 250);
            dwvProductos.Margin = new Padding(4, 5, 4, 5);
            dwvProductos.Name = "dwvProductos";
            dwvProductos.RowHeadersWidth = 62;
            dwvProductos.Size = new Size(457, 243);
            dwvProductos.TabIndex = 0;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 750);
            Controls.Add(dwvProductos);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dwvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dwvProductos;
    }
}