namespace Gina
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            adminbtn = new FontAwesome.Sharp.IconButton();
            graficButton = new FontAwesome.Sharp.IconButton();
            productsButton = new FontAwesome.Sharp.IconButton();
            OrdenesButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnInicio = new PictureBox();
            panelTitleBar = new Panel();
            btnMax = new FontAwesome.Sharp.IconPictureBox();
            btnMin = new FontAwesome.Sharp.IconPictureBox();
            btnCloseW = new FontAwesome.Sharp.IconPictureBox();
            lbTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(106, 113, 113);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(adminbtn);
            panelMenu.Controls.Add(graficButton);
            panelMenu.Controls.Add(productsButton);
            panelMenu.Controls.Add(OrdenesButton);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(181, 449);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogout.IconColor = Color.WhiteSmoke;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 269);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(7, 0, 14, 0);
            btnLogout.Size = new Size(181, 52);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // adminbtn
            // 
            adminbtn.Dock = DockStyle.Top;
            adminbtn.FlatAppearance.BorderSize = 0;
            adminbtn.FlatStyle = FlatStyle.Flat;
            adminbtn.ForeColor = SystemColors.Control;
            adminbtn.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            adminbtn.IconColor = Color.WhiteSmoke;
            adminbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminbtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminbtn.Location = new Point(0, 219);
            adminbtn.Margin = new Padding(2, 2, 2, 2);
            adminbtn.Name = "adminbtn";
            adminbtn.Padding = new Padding(7, 0, 14, 0);
            adminbtn.Size = new Size(181, 50);
            adminbtn.TabIndex = 6;
            adminbtn.Text = "Admin";
            adminbtn.TextAlign = ContentAlignment.MiddleLeft;
            adminbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            adminbtn.UseVisualStyleBackColor = true;
            adminbtn.Click += adminbtn_Click;
            // 
            // graficButton
            // 
            graficButton.Dock = DockStyle.Top;
            graficButton.FlatAppearance.BorderSize = 0;
            graficButton.FlatStyle = FlatStyle.Flat;
            graficButton.ForeColor = SystemColors.Control;
            graficButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            graficButton.IconColor = Color.WhiteSmoke;
            graficButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            graficButton.ImageAlign = ContentAlignment.MiddleLeft;
            graficButton.Location = new Point(0, 171);
            graficButton.Margin = new Padding(2, 2, 2, 2);
            graficButton.Name = "graficButton";
            graficButton.Padding = new Padding(7, 0, 14, 0);
            graficButton.Size = new Size(181, 48);
            graficButton.TabIndex = 3;
            graficButton.Text = "Gráfica";
            graficButton.TextAlign = ContentAlignment.MiddleLeft;
            graficButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            graficButton.UseVisualStyleBackColor = true;
            graficButton.Click += graficButton_Click;
            // 
            // productsButton
            // 
            productsButton.Dock = DockStyle.Top;
            productsButton.FlatAppearance.BorderSize = 0;
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.ForeColor = SystemColors.Control;
            productsButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            productsButton.IconColor = Color.WhiteSmoke;
            productsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            productsButton.ImageAlign = ContentAlignment.MiddleLeft;
            productsButton.Location = new Point(0, 124);
            productsButton.Margin = new Padding(2, 2, 2, 2);
            productsButton.Name = "productsButton";
            productsButton.Padding = new Padding(7, 0, 14, 0);
            productsButton.Size = new Size(181, 47);
            productsButton.TabIndex = 2;
            productsButton.Text = "Productos";
            productsButton.TextAlign = ContentAlignment.MiddleLeft;
            productsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // OrdenesButton
            // 
            OrdenesButton.Dock = DockStyle.Top;
            OrdenesButton.FlatAppearance.BorderSize = 0;
            OrdenesButton.FlatStyle = FlatStyle.Flat;
            OrdenesButton.ForeColor = SystemColors.Control;
            OrdenesButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            OrdenesButton.IconColor = Color.WhiteSmoke;
            OrdenesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OrdenesButton.ImageAlign = ContentAlignment.MiddleLeft;
            OrdenesButton.Location = new Point(0, 75);
            OrdenesButton.Margin = new Padding(2, 2, 2, 2);
            OrdenesButton.Name = "OrdenesButton";
            OrdenesButton.Padding = new Padding(7, 0, 14, 0);
            OrdenesButton.Size = new Size(181, 49);
            OrdenesButton.TabIndex = 1;
            OrdenesButton.Text = "Ordenes";
            OrdenesButton.TextAlign = ContentAlignment.MiddleLeft;
            OrdenesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrdenesButton.UseVisualStyleBackColor = true;
            OrdenesButton.Click += OrdenesButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 75);
            panel1.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(24, 7);
            btnInicio.Margin = new Padding(2, 2, 2, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(118, 59);
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(106, 113, 113);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnMin);
            panelTitleBar.Controls.Add(btnCloseW);
            panelTitleBar.Controls.Add(lbTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(181, 0);
            panelTitleBar.Margin = new Padding(2, 2, 2, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(778, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.FromArgb(106, 113, 113);
            btnMax.ForeColor = SystemColors.Control;
            btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMax.IconColor = SystemColors.Control;
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 21;
            btnMax.Location = new Point(721, 0);
            btnMax.Margin = new Padding(2, 2, 2, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(28, 21);
            btnMax.TabIndex = 4;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.FromArgb(106, 113, 113);
            btnMin.ForeColor = SystemColors.Control;
            btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMin.IconColor = SystemColors.Control;
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 22;
            btnMin.Location = new Point(692, 0);
            btnMin.Margin = new Padding(2, 2, 2, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(25, 22);
            btnMin.TabIndex = 3;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnCloseW
            // 
            btnCloseW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseW.BackColor = Color.FromArgb(106, 113, 113);
            btnCloseW.ForeColor = SystemColors.Control;
            btnCloseW.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCloseW.IconColor = SystemColors.Control;
            btnCloseW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseW.IconSize = 21;
            btnCloseW.Location = new Point(753, 0);
            btnCloseW.Margin = new Padding(2, 2, 2, 2);
            btnCloseW.Name = "btnCloseW";
            btnCloseW.Size = new Size(24, 21);
            btnCloseW.TabIndex = 2;
            btnCloseW.TabStop = false;
            btnCloseW.Click += btnCloseW_Click;
            // 
            // lbTitleChildForm
            // 
            lbTitleChildForm.AutoSize = true;
            lbTitleChildForm.Location = new Point(47, 22);
            lbTitleChildForm.Margin = new Padding(2, 0, 2, 0);
            lbTitleChildForm.Name = "lbTitleChildForm";
            lbTitleChildForm.Size = new Size(40, 15);
            lbTitleChildForm.TabIndex = 1;
            lbTitleChildForm.Text = "Home";
            lbTitleChildForm.Click += lbTitleChildForm_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(106, 113, 113);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 23;
            iconCurrentChildForm.Location = new Point(16, 22);
            iconCurrentChildForm.Margin = new Padding(2, 2, 2, 2);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(27, 23);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(106, 113, 113);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(181, 75);
            panelShadow.Margin = new Padding(2, 2, 2, 2);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(778, 7);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(181, 82);
            panelDesktop.Margin = new Padding(2, 2, 2, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(778, 367);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 449);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMenu";
            Text = "Form1";
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseW).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton OrdenesButton;
        private FontAwesome.Sharp.IconButton adminbtn;
        private FontAwesome.Sharp.IconButton graficButton;
        private FontAwesome.Sharp.IconButton productsButton;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lbTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnCloseW;
        private FontAwesome.Sharp.IconPictureBox btnMax;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private FontAwesome.Sharp.IconButton btnLogout;
        private PictureBox btnInicio;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
