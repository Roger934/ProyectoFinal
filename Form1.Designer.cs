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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            adminbtn = new FontAwesome.Sharp.IconButton();
            graficButton = new FontAwesome.Sharp.IconButton();
            productsButton = new FontAwesome.Sharp.IconButton();
            OrdenesButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnInicio = new PictureBox();
            panelTitleBar = new Panel();
            label3 = new Label();
            label1 = new Label();
            btnPause = new Guna.UI2.WinForms.Guna2GradientButton();
            btnPlay = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            txtUsu = new TextBox();
            label2 = new Label();
            btnMax = new FontAwesome.Sharp.IconPictureBox();
            btnMin = new FontAwesome.Sharp.IconPictureBox();
            btnCloseW = new FontAwesome.Sharp.IconPictureBox();
            lbTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
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
            panelMenu.Margin = new Padding(2, 4, 2, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(259, 823);
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
            btnLogout.Location = new Point(0, 449);
            btnLogout.Margin = new Padding(2, 4, 2, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 20, 0);
            btnLogout.Size = new Size(259, 86);
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
            adminbtn.Location = new Point(0, 365);
            adminbtn.Margin = new Padding(2, 4, 2, 4);
            adminbtn.Name = "adminbtn";
            adminbtn.Padding = new Padding(10, 0, 20, 0);
            adminbtn.Size = new Size(259, 84);
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
            graficButton.Location = new Point(0, 285);
            graficButton.Margin = new Padding(2, 4, 2, 4);
            graficButton.Name = "graficButton";
            graficButton.Padding = new Padding(10, 0, 20, 0);
            graficButton.Size = new Size(259, 80);
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
            productsButton.Location = new Point(0, 206);
            productsButton.Margin = new Padding(2, 4, 2, 4);
            productsButton.Name = "productsButton";
            productsButton.Padding = new Padding(10, 0, 20, 0);
            productsButton.Size = new Size(259, 79);
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
            OrdenesButton.Location = new Point(0, 125);
            OrdenesButton.Margin = new Padding(2, 4, 2, 4);
            OrdenesButton.Name = "OrdenesButton";
            OrdenesButton.Padding = new Padding(10, 0, 20, 0);
            OrdenesButton.Size = new Size(259, 81);
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
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 125);
            panel1.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.logo;
            btnInicio.Location = new Point(39, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(171, 125);
            btnInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(106, 113, 113);
            panelTitleBar.Controls.Add(label3);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(btnPause);
            panelTitleBar.Controls.Add(btnPlay);
            panelTitleBar.Controls.Add(txtUsu);
            panelTitleBar.Controls.Add(label2);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnMin);
            panelTitleBar.Controls.Add(btnCloseW);
            panelTitleBar.Controls.Add(lbTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(259, 0);
            panelTitleBar.Margin = new Padding(2, 4, 2, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1183, 125);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 0);
            label3.Name = "label3";
            label3.Size = new Size(393, 25);
            label3.TabIndex = 10;
            label3.Text = "Aqui te equipamos, la condición ya es tu bronca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 96);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 9;
            label1.Text = "DN Deport";
            // 
            // btnPause
            // 
            btnPause.CustomizableEdges = customizableEdges1;
            btnPause.DisabledState.BorderColor = Color.DarkGray;
            btnPause.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPause.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPause.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnPause.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPause.Font = new Font("Segoe UI", 9F);
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(354, 42);
            btnPause.Name = "btnPause";
            btnPause.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPause.Size = new Size(43, 41);
            btnPause.TabIndex = 8;
            btnPause.Text = "||";
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.DisabledState.BorderColor = Color.DarkGray;
            btnPlay.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlay.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnPlay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlay.Font = new Font("Segoe UI", 9F);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(278, 36);
            btnPlay.Name = "btnPlay";
            btnPlay.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnPlay.Size = new Size(53, 47);
            btnPlay.TabIndex = 7;
            btnPlay.Text = "|>";
            btnPlay.Click += btnPlay_Click;
            // 
            // txtUsu
            // 
            txtUsu.BackColor = Color.FromArgb(106, 113, 113);
            txtUsu.Location = new Point(898, 65);
            txtUsu.Margin = new Padding(4);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(198, 31);
            txtUsu.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "label1";
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.FromArgb(106, 113, 113);
            btnMax.ForeColor = SystemColors.Control;
            btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMax.IconColor = SystemColors.Control;
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 35;
            btnMax.Location = new Point(1102, 0);
            btnMax.Margin = new Padding(2, 4, 2, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 35);
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
            btnMin.IconSize = 36;
            btnMin.Location = new Point(1061, 0);
            btnMin.Margin = new Padding(2, 4, 2, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(36, 36);
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
            btnCloseW.IconSize = 34;
            btnCloseW.Location = new Point(1148, 0);
            btnCloseW.Margin = new Padding(2, 4, 2, 4);
            btnCloseW.Name = "btnCloseW";
            btnCloseW.Size = new Size(34, 35);
            btnCloseW.TabIndex = 2;
            btnCloseW.TabStop = false;
            btnCloseW.Click += btnCloseW_Click;
            // 
            // lbTitleChildForm
            // 
            lbTitleChildForm.AutoSize = true;
            lbTitleChildForm.Location = new Point(68, 36);
            lbTitleChildForm.Margin = new Padding(2, 0, 2, 0);
            lbTitleChildForm.Name = "lbTitleChildForm";
            lbTitleChildForm.Size = new Size(61, 25);
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
            iconCurrentChildForm.IconSize = 39;
            iconCurrentChildForm.Location = new Point(22, 36);
            iconCurrentChildForm.Margin = new Padding(2, 4, 2, 4);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(39, 39);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(106, 113, 113);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(259, 125);
            panelShadow.Margin = new Padding(2, 4, 2, 4);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1183, 11);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(259, 136);
            panelDesktop.Margin = new Padding(2, 4, 2, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1183, 687);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 823);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Control;
            Margin = new Padding(2, 4, 2, 4);
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
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtUsu;
        private Guna.UI2.WinForms.Guna2GradientButton btnPause;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnPlay;
        private PictureBox btnInicio;
        private Label label3;
        private Label label1;
    }
}
