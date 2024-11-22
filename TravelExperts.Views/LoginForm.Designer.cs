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
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(89, 65);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Please Enter Username";
            txt_username.Size = new Size(199, 23);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(86, 154);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Enter Your Password";
            txt_password.Size = new Size(199, 23);
            txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(144, 213);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 28);
            btn_login.TabIndex = 4;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 275);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
    }
}