namespace TravelExperts.Views
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            panelMain = new Panel();
            panelDesktopPanel = new Panel();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            labelTitle = new Label();
            panelMenu = new Panel();
            btnLogOut = new Button();
            btnAdmin = new Button();
            btnPackages = new Button();
            btnSuppliers = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelMain.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(panelDesktopPanel);
            panelMain.Controls.Add(panelTitleBar);
            panelMain.Controls.Add(panelMenu);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1334, 761);
            panelMain.TabIndex = 0;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.BackgroundImage = (Image)resources.GetObject("panelDesktopPanel.BackgroundImage");
            panelDesktopPanel.BackgroundImageLayout = ImageLayout.Zoom;
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(336, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(998, 681);
            panelDesktopPanel.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(60, 63, 65);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(336, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(998, 80);
            panelTitleBar.TabIndex = 4;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Cursor = Cursors.Hand;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Visible = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(446, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(96, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HOME";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(60, 63, 65);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnAdmin);
            panelMenu.Controls.Add(btnPackages);
            panelMenu.Controls.Add(btnSuppliers);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(336, 761);
            panelMenu.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Coral;
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderColor = Color.White;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Palatino Linotype", 12F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 701);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(12, 0, 0, 0);
            btnLogOut.Size = new Size(336, 60);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "       Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.DodgerBlue;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderColor = Color.White;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 200);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(12, 0, 0, 0);
            btnAdmin.Size = new Size(336, 60);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "       Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnPackages
            // 
            btnPackages.BackColor = Color.LightGreen;
            btnPackages.Cursor = Cursors.Hand;
            btnPackages.Dock = DockStyle.Top;
            btnPackages.FlatAppearance.BorderColor = Color.White;
            btnPackages.FlatAppearance.BorderSize = 0;
            btnPackages.FlatStyle = FlatStyle.Flat;
            btnPackages.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPackages.ForeColor = Color.White;
            btnPackages.Image = (Image)resources.GetObject("btnPackages.Image");
            btnPackages.ImageAlign = ContentAlignment.MiddleLeft;
            btnPackages.Location = new Point(0, 140);
            btnPackages.Name = "btnPackages";
            btnPackages.Padding = new Padding(12, 0, 0, 0);
            btnPackages.Size = new Size(336, 60);
            btnPackages.TabIndex = 3;
            btnPackages.Text = "       Packages";
            btnPackages.TextAlign = ContentAlignment.MiddleLeft;
            btnPackages.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPackages.UseVisualStyleBackColor = false;
            btnPackages.Click += btnPackages_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.LightBlue;
            btnSuppliers.Cursor = Cursors.Hand;
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatAppearance.BorderColor = Color.White;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(0, 80);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Padding = new Padding(12, 0, 0, 0);
            btnSuppliers.Size = new Size(336, 60);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "       Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(60, 63, 65);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(12, 0, 0, 0);
            panelLogo.Size = new Size(336, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 761);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1350, 800);
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            panelMain.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelDesktopPanel;
        private Panel panelTitleBar;
        private Button btnCloseChildForm;
        private Label labelTitle;
        private Panel panelMenu;
        private Button btnLogOut;
        private Button btnAdmin;
        private Button btnPackages;
        private Button btnSuppliers;
        private Panel panelLogo;
        private PictureBox pictureBox1;
    }
}