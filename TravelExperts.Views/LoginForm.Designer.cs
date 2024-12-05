namespace TravelExperts.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelMain = new Panel();
            panelDesktopPanel = new Panel();
            btnExit = new Button();
            pictureBoxTop = new PictureBox();
            panelRight = new Panel();
            panelLeft = new Panel();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label1 = new Label();
            btn_login = new Button();
            label2 = new Label();
            panelMain.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTop).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(panelDesktopPanel);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1384, 861);
            panelMain.TabIndex = 0;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDesktopPanel.Controls.Add(btnExit);
            panelDesktopPanel.Controls.Add(pictureBoxTop);
            panelDesktopPanel.Controls.Add(panelRight);
            panelDesktopPanel.Controls.Add(panelLeft);
            panelDesktopPanel.Controls.Add(txt_password);
            panelDesktopPanel.Controls.Add(txt_username);
            panelDesktopPanel.Controls.Add(label1);
            panelDesktopPanel.Controls.Add(btn_login);
            panelDesktopPanel.Controls.Add(label2);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(0, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1384, 861);
            panelDesktopPanel.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Coral;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(578, 635);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(308, 43);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBoxTop
            // 
            pictureBoxTop.BackColor = Color.LightGray;
            pictureBoxTop.Dock = DockStyle.Top;
            pictureBoxTop.Image = (Image)resources.GetObject("pictureBoxTop.Image");
            pictureBoxTop.Location = new Point(200, 0);
            pictureBoxTop.Name = "pictureBoxTop";
            pictureBoxTop.Size = new Size(984, 279);
            pictureBoxTop.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTop.TabIndex = 7;
            pictureBoxTop.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(60, 63, 65);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1184, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(200, 861);
            panelRight.TabIndex = 6;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(60, 63, 65);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 861);
            panelLeft.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_password.BackColor = SystemColors.Info;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(578, 475);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Enter Your Password";
            txt_password.Size = new Size(308, 26);
            txt_password.TabIndex = 3;
            txt_password.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_username.BackColor = SystemColors.Info;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(578, 365);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Please Enter Username";
            txt_username.Size = new Size(308, 26);
            txt_username.TabIndex = 2;
            txt_username.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            label1.Location = new Point(578, 312);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.FromArgb(128, 255, 128);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(578, 563);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(308, 43);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            label2.Location = new Point(578, 440);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1384, 861);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1400, 900);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panelMain.ResumeLayout(false);
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelDesktopPanel;
        private Button btnExit;
        private PictureBox pictureBoxTop;
        private Panel panelRight;
        private Panel panelLeft;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label1;
        private Button btn_login;
        private Label label2;
    }
}