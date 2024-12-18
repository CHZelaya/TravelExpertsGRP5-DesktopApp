﻿namespace TravelExperts.Views
{
    partial class frmAdminAgentsManagement
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
            label_AgentsTitle = new Label();
            groupBox1 = new GroupBox();
            comboBox_AgtPosition = new ComboBox();
            button_Cancel = new Button();
            button_OK = new Button();
            textBox_AgentEmail = new TextBox();
            textBox_AgentBussPhone = new TextBox();
            textBox_AgentLName = new TextBox();
            textBox_AgentMInitial = new TextBox();
            textBox_AgentFName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label_AgentsTitle
            // 
            label_AgentsTitle.AutoSize = true;
            label_AgentsTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_AgentsTitle.Location = new Point(259, 61);
            label_AgentsTitle.Name = "label_AgentsTitle";
            label_AgentsTitle.Size = new Size(76, 36);
            label_AgentsTitle.TabIndex = 0;
            label_AgentsTitle.Text = "Title";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_AgtPosition);
            groupBox1.Controls.Add(button_Cancel);
            groupBox1.Controls.Add(button_OK);
            groupBox1.Controls.Add(textBox_AgentEmail);
            groupBox1.Controls.Add(textBox_AgentBussPhone);
            groupBox1.Controls.Add(textBox_AgentLName);
            groupBox1.Controls.Add(textBox_AgentMInitial);
            groupBox1.Controls.Add(textBox_AgentFName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(129, 132);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(582, 383);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agent Details";
            // 
            // comboBox_AgtPosition
            // 
            comboBox_AgtPosition.FormattingEnabled = true;
            comboBox_AgtPosition.Items.AddRange(new object[] { "Junior Agent", "Intermidiate Agent", "Senior Agent" });
            comboBox_AgtPosition.Location = new Point(130, 301);
            comboBox_AgtPosition.Margin = new Padding(3, 4, 3, 4);
            comboBox_AgtPosition.Name = "comboBox_AgtPosition";
            comboBox_AgtPosition.Size = new Size(230, 28);
            comboBox_AgtPosition.TabIndex = 2;
            comboBox_AgtPosition.Tag = "Agent Position";
            // 
            // button_Cancel
            // 
            button_Cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button_Cancel.FlatStyle = FlatStyle.Flat;
            button_Cancel.Location = new Point(410, 235);
            button_Cancel.Margin = new Padding(3, 4, 3, 4);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(119, 76);
            button_Cancel.TabIndex = 12;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // button_OK
            // 
            button_OK.FlatAppearance.MouseDownBackColor = Color.Lime;
            button_OK.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button_OK.FlatStyle = FlatStyle.Flat;
            button_OK.Location = new Point(410, 103);
            button_OK.Margin = new Padding(3, 4, 3, 4);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(119, 76);
            button_OK.TabIndex = 2;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // textBox_AgentEmail
            // 
            textBox_AgentEmail.Location = new Point(130, 257);
            textBox_AgentEmail.Margin = new Padding(3, 4, 3, 4);
            textBox_AgentEmail.Name = "textBox_AgentEmail";
            textBox_AgentEmail.Size = new Size(230, 27);
            textBox_AgentEmail.TabIndex = 10;
            textBox_AgentEmail.Tag = "Email";
            // 
            // textBox_AgentBussPhone
            // 
            textBox_AgentBussPhone.Location = new Point(130, 208);
            textBox_AgentBussPhone.Margin = new Padding(3, 4, 3, 4);
            textBox_AgentBussPhone.Name = "textBox_AgentBussPhone";
            textBox_AgentBussPhone.Size = new Size(230, 27);
            textBox_AgentBussPhone.TabIndex = 9;
            textBox_AgentBussPhone.Tag = "Phone Number";
            // 
            // textBox_AgentLName
            // 
            textBox_AgentLName.Location = new Point(130, 165);
            textBox_AgentLName.Margin = new Padding(3, 4, 3, 4);
            textBox_AgentLName.Name = "textBox_AgentLName";
            textBox_AgentLName.Size = new Size(230, 27);
            textBox_AgentLName.TabIndex = 8;
            textBox_AgentLName.Tag = "Last Name";
            // 
            // textBox_AgentMInitial
            // 
            textBox_AgentMInitial.Location = new Point(130, 120);
            textBox_AgentMInitial.Margin = new Padding(3, 4, 3, 4);
            textBox_AgentMInitial.Name = "textBox_AgentMInitial";
            textBox_AgentMInitial.Size = new Size(230, 27);
            textBox_AgentMInitial.TabIndex = 7;
            textBox_AgentMInitial.Tag = "Middle Initial";
            // 
            // textBox_AgentFName
            // 
            textBox_AgentFName.Location = new Point(130, 73);
            textBox_AgentFName.Margin = new Padding(3, 4, 3, 4);
            textBox_AgentFName.Name = "textBox_AgentFName";
            textBox_AgentFName.Size = new Size(230, 27);
            textBox_AgentFName.TabIndex = 6;
            textBox_AgentFName.Tag = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 312);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 5;
            label6.Text = "Position :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 268);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 219);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 176);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 131);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Middle Initial :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 84);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // frmAdminAgentsManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(805, 605);
            Controls.Add(groupBox1);
            Controls.Add(label_AgentsTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdminAgentsManagement";
            Text = "Admin Agents Management";
            Load += frmAdminAgentsManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_AgentsTitle;
        private GroupBox groupBox1;
        private TextBox textBox_AgentEmail;
        private TextBox textBox_AgentBussPhone;
        private TextBox textBox_AgentLName;
        private TextBox textBox_AgentMInitial;
        private TextBox textBox_AgentFName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_Cancel;
        private Button button_OK;
        private ComboBox comboBox_AgtPosition;
    }
}