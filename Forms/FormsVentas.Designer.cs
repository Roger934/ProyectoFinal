namespace Gina.Forms
{
    partial class FormsVentas
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
            txtVentas = new TextBox();
            SuspendLayout();
            // 
            // txtVentas
            // 
            txtVentas.Location = new Point(238, 181);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(125, 27);
            txtVentas.TabIndex = 0;
            // 
            // FormsVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 439);
            Controls.Add(txtVentas);
            Name = "FormsVentas";
            Text = "FormsVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVentas;
    }
}