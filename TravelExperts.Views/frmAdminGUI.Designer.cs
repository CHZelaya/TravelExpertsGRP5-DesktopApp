


namespace TravelExperts.Views
{
    partial class frmAdminGUI
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
            label1 = new Label();
            button_AgenciesBack = new Button();
            label2 = new Label();
            textBox_AgencyID1 = new TextBox();
            textBox_AgencyAddress = new TextBox();
            textBox_AgencyCity = new TextBox();
            textBox_AgencyProvince = new TextBox();
            textBox_AgencyBusPhone = new TextBox();
            textBox_AgencyCountry = new TextBox();
            textBox_AgencyPostal = new TextBox();
            textBox_AgentPosition = new TextBox();
            textBox_AgentEmail = new TextBox();
            textBox_AgentBussPhone = new TextBox();
            textBox_AgentLName = new TextBox();
            textBox_AgentMInitial = new TextBox();
            textBox_AgentFName = new TextBox();
            button_AgencyAdd = new Button();
            button_AgencyEdit = new Button();
            button_AgencyDelete = new Button();
            button_AgentDelete = new Button();
            button_AgentEdit = new Button();
            button_AgentAdd = new Button();
            label3 = new Label();
            button_AgentForward = new Button();
            button_AgentBack = new Button();
            label4 = new Label();
            textBox_AgentID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox_AgencyFaxPhone = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panel1 = new Panel();
            textBox_AgencyID2 = new TextBox();
            button_AgenciesForward = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Agencies";
            // 
            // button_AgenciesBack
            // 
            button_AgenciesBack.Location = new Point(21, 53);
            button_AgenciesBack.Margin = new Padding(3, 2, 3, 2);
            button_AgenciesBack.Name = "button_AgenciesBack";
            button_AgenciesBack.Size = new Size(47, 25);
            button_AgenciesBack.TabIndex = 2;
            button_AgenciesBack.Text = "<";
            button_AgenciesBack.UseVisualStyleBackColor = true;
            button_AgenciesBack.Click += button_AgenciesBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Agency ID";
            // 
            // textBox_AgencyID1
            // 
            textBox_AgencyID1.Location = new Point(500, 56);
            textBox_AgencyID1.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyID1.Name = "textBox_AgencyID1";
            textBox_AgencyID1.ReadOnly = true;
            textBox_AgencyID1.Size = new Size(35, 23);
            textBox_AgencyID1.TabIndex = 5;
            textBox_AgencyID1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_AgencyAddress
            // 
            textBox_AgencyAddress.Location = new Point(21, 109);
            textBox_AgencyAddress.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyAddress.Name = "textBox_AgencyAddress";
            textBox_AgencyAddress.ReadOnly = true;
            textBox_AgencyAddress.Size = new Size(153, 23);
            textBox_AgencyAddress.TabIndex = 6;
            // 
            // textBox_AgencyCity
            // 
            textBox_AgencyCity.Location = new Point(200, 109);
            textBox_AgencyCity.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyCity.Name = "textBox_AgencyCity";
            textBox_AgencyCity.ReadOnly = true;
            textBox_AgencyCity.Size = new Size(153, 23);
            textBox_AgencyCity.TabIndex = 7;
            // 
            // textBox_AgencyProvince
            // 
            textBox_AgencyProvince.Location = new Point(382, 109);
            textBox_AgencyProvince.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyProvince.Name = "textBox_AgencyProvince";
            textBox_AgencyProvince.ReadOnly = true;
            textBox_AgencyProvince.Size = new Size(153, 23);
            textBox_AgencyProvince.TabIndex = 8;
            // 
            // textBox_AgencyBusPhone
            // 
            textBox_AgencyBusPhone.Location = new Point(382, 156);
            textBox_AgencyBusPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyBusPhone.Name = "textBox_AgencyBusPhone";
            textBox_AgencyBusPhone.ReadOnly = true;
            textBox_AgencyBusPhone.Size = new Size(153, 23);
            textBox_AgencyBusPhone.TabIndex = 11;
            // 
            // textBox_AgencyCountry
            // 
            textBox_AgencyCountry.Location = new Point(200, 156);
            textBox_AgencyCountry.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyCountry.Name = "textBox_AgencyCountry";
            textBox_AgencyCountry.ReadOnly = true;
            textBox_AgencyCountry.Size = new Size(153, 23);
            textBox_AgencyCountry.TabIndex = 10;
            // 
            // textBox_AgencyPostal
            // 
            textBox_AgencyPostal.Location = new Point(21, 156);
            textBox_AgencyPostal.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyPostal.Name = "textBox_AgencyPostal";
            textBox_AgencyPostal.ReadOnly = true;
            textBox_AgencyPostal.Size = new Size(153, 23);
            textBox_AgencyPostal.TabIndex = 9;
            // 
            // textBox_AgentPosition
            // 
            textBox_AgentPosition.Location = new Point(200, 466);
            textBox_AgentPosition.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentPosition.Name = "textBox_AgentPosition";
            textBox_AgentPosition.ReadOnly = true;
            textBox_AgentPosition.Size = new Size(153, 23);
            textBox_AgentPosition.TabIndex = 17;
            // 
            // textBox_AgentEmail
            // 
            textBox_AgentEmail.Location = new Point(21, 522);
            textBox_AgentEmail.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentEmail.Name = "textBox_AgentEmail";
            textBox_AgentEmail.ReadOnly = true;
            textBox_AgentEmail.Size = new Size(184, 23);
            textBox_AgentEmail.TabIndex = 16;
            // 
            // textBox_AgentBussPhone
            // 
            textBox_AgentBussPhone.Location = new Point(21, 468);
            textBox_AgentBussPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentBussPhone.Name = "textBox_AgentBussPhone";
            textBox_AgentBussPhone.ReadOnly = true;
            textBox_AgentBussPhone.Size = new Size(153, 23);
            textBox_AgentBussPhone.TabIndex = 15;
            // 
            // textBox_AgentLName
            // 
            textBox_AgentLName.Location = new Point(382, 422);
            textBox_AgentLName.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentLName.Name = "textBox_AgentLName";
            textBox_AgentLName.ReadOnly = true;
            textBox_AgentLName.Size = new Size(153, 23);
            textBox_AgentLName.TabIndex = 14;
            // 
            // textBox_AgentMInitial
            // 
            textBox_AgentMInitial.Location = new Point(200, 422);
            textBox_AgentMInitial.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentMInitial.Name = "textBox_AgentMInitial";
            textBox_AgentMInitial.ReadOnly = true;
            textBox_AgentMInitial.Size = new Size(153, 23);
            textBox_AgentMInitial.TabIndex = 13;
            // 
            // textBox_AgentFName
            // 
            textBox_AgentFName.Location = new Point(21, 422);
            textBox_AgentFName.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentFName.Name = "textBox_AgentFName";
            textBox_AgentFName.ReadOnly = true;
            textBox_AgentFName.Size = new Size(153, 23);
            textBox_AgentFName.TabIndex = 12;
            // 
            // button_AgencyAdd
            // 
            button_AgencyAdd.Location = new Point(21, 231);
            button_AgencyAdd.Margin = new Padding(3, 2, 3, 2);
            button_AgencyAdd.Name = "button_AgencyAdd";
            button_AgencyAdd.Size = new Size(152, 36);
            button_AgencyAdd.TabIndex = 18;
            button_AgencyAdd.Text = "Add Agency";
            button_AgencyAdd.UseVisualStyleBackColor = true;
            // 
            // button_AgencyEdit
            // 
            button_AgencyEdit.Location = new Point(200, 231);
            button_AgencyEdit.Margin = new Padding(3, 2, 3, 2);
            button_AgencyEdit.Name = "button_AgencyEdit";
            button_AgencyEdit.Size = new Size(152, 36);
            button_AgencyEdit.TabIndex = 19;
            button_AgencyEdit.Text = "Edit Agency";
            button_AgencyEdit.UseVisualStyleBackColor = true;
            // 
            // button_AgencyDelete
            // 
            button_AgencyDelete.Location = new Point(382, 231);
            button_AgencyDelete.Margin = new Padding(3, 2, 3, 2);
            button_AgencyDelete.Name = "button_AgencyDelete";
            button_AgencyDelete.Size = new Size(152, 36);
            button_AgencyDelete.TabIndex = 20;
            button_AgencyDelete.Text = "Delete Agency";
            button_AgencyDelete.UseVisualStyleBackColor = true;
            // 
            // button_AgentDelete
            // 
            button_AgentDelete.Location = new Point(383, 559);
            button_AgentDelete.Margin = new Padding(3, 2, 3, 2);
            button_AgentDelete.Name = "button_AgentDelete";
            button_AgentDelete.Size = new Size(152, 36);
            button_AgentDelete.TabIndex = 23;
            button_AgentDelete.Text = "Delete Agent";
            button_AgentDelete.UseVisualStyleBackColor = true;
            // 
            // button_AgentEdit
            // 
            button_AgentEdit.Location = new Point(201, 559);
            button_AgentEdit.Margin = new Padding(3, 2, 3, 2);
            button_AgentEdit.Name = "button_AgentEdit";
            button_AgentEdit.Size = new Size(152, 36);
            button_AgentEdit.TabIndex = 22;
            button_AgentEdit.Text = "Edit Agent";
            button_AgentEdit.UseVisualStyleBackColor = true;
            // 
            // button_AgentAdd
            // 
            button_AgentAdd.Location = new Point(22, 559);
            button_AgentAdd.Margin = new Padding(3, 2, 3, 2);
            button_AgentAdd.Name = "button_AgentAdd";
            button_AgentAdd.Size = new Size(152, 36);
            button_AgentAdd.TabIndex = 21;
            button_AgentAdd.Text = "Add Agent";
            button_AgentAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 374);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 28;
            label3.Text = "Agency ID:";
            // 
            // button_AgentForward
            // 
            button_AgentForward.Location = new Point(74, 372);
            button_AgentForward.Margin = new Padding(3, 2, 3, 2);
            button_AgentForward.Name = "button_AgentForward";
            button_AgentForward.Size = new Size(45, 24);
            button_AgentForward.TabIndex = 27;
            button_AgentForward.Text = ">";
            button_AgentForward.UseVisualStyleBackColor = true;
            button_AgentForward.Click += button_AgentForward_Click;
            // 
            // button_AgentBack
            // 
            button_AgentBack.Location = new Point(21, 371);
            button_AgentBack.Margin = new Padding(3, 2, 3, 2);
            button_AgentBack.Name = "button_AgentBack";
            button_AgentBack.Size = new Size(47, 24);
            button_AgentBack.TabIndex = 26;
            button_AgentBack.Text = "<";
            button_AgentBack.UseVisualStyleBackColor = true;
            button_AgentBack.Click += button_AgentBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(22, 328);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 24;
            label4.Text = "Agents";
            // 
            // textBox_AgentID
            // 
            textBox_AgentID.Location = new Point(500, 373);
            textBox_AgentID.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentID.Name = "textBox_AgentID";
            textBox_AgentID.ReadOnly = true;
            textBox_AgentID.Size = new Size(35, 23);
            textBox_AgentID.TabIndex = 31;
            textBox_AgentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 374);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 30;
            label5.Text = "Agent ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 92);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 32;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 92);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 33;
            label7.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 92);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 34;
            label8.Text = "Province";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 135);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 35;
            label9.Text = "Postal Code";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(200, 134);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 36;
            label10.Text = "Country";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(382, 135);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 37;
            label11.Text = "Business Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(382, 179);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 38;
            label12.Text = "Business Fax";
            // 
            // textBox_AgencyFaxPhone
            // 
            textBox_AgencyFaxPhone.Location = new Point(382, 196);
            textBox_AgencyFaxPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyFaxPhone.Name = "textBox_AgencyFaxPhone";
            textBox_AgencyFaxPhone.ReadOnly = true;
            textBox_AgencyFaxPhone.Size = new Size(153, 23);
            textBox_AgencyFaxPhone.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 404);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 40;
            label13.Text = "First Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(200, 405);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 41;
            label14.Text = "Middle Initial";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(380, 406);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 42;
            label15.Text = "Last Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 451);
            label16.Name = "label16";
            label16.Size = new Size(92, 15);
            label16.TabIndex = 43;
            label16.Text = "Business Phone ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 505);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 44;
            label17.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(200, 451);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 45;
            label18.Text = "Position";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InfoText;
            panel1.Location = new Point(0, 307);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 10);
            panel1.TabIndex = 99;
            // 
            // textBox_AgencyID2
            // 
            textBox_AgencyID2.Location = new Point(389, 372);
            textBox_AgencyID2.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyID2.Name = "textBox_AgencyID2";
            textBox_AgencyID2.ReadOnly = true;
            textBox_AgencyID2.Size = new Size(35, 23);
            textBox_AgencyID2.TabIndex = 100;
            textBox_AgencyID2.TextAlign = HorizontalAlignment.Center;
            // 
            // button_AgenciesForward
            // 
            button_AgenciesForward.Location = new Point(74, 54);
            button_AgenciesForward.Margin = new Padding(3, 2, 3, 2);
            button_AgenciesForward.Name = "button_AgenciesForward";
            button_AgenciesForward.Size = new Size(45, 25);
            button_AgenciesForward.TabIndex = 101;
            button_AgenciesForward.Text = ">";
            button_AgenciesForward.UseVisualStyleBackColor = true;
            button_AgenciesForward.Click += button_AgenciesForward_Click;
            // 
            // frmAdminGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(585, 635);
            Controls.Add(button_AgenciesForward);
            Controls.Add(textBox_AgencyID2);
            Controls.Add(panel1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox_AgencyFaxPhone);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox_AgentID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button_AgentForward);
            Controls.Add(button_AgentBack);
            Controls.Add(label4);
            Controls.Add(button_AgentDelete);
            Controls.Add(button_AgentEdit);
            Controls.Add(button_AgentAdd);
            Controls.Add(button_AgencyDelete);
            Controls.Add(button_AgencyEdit);
            Controls.Add(button_AgencyAdd);
            Controls.Add(textBox_AgentPosition);
            Controls.Add(textBox_AgentEmail);
            Controls.Add(textBox_AgentBussPhone);
            Controls.Add(textBox_AgentLName);
            Controls.Add(textBox_AgentMInitial);
            Controls.Add(textBox_AgentFName);
            Controls.Add(textBox_AgencyBusPhone);
            Controls.Add(textBox_AgencyCountry);
            Controls.Add(textBox_AgencyPostal);
            Controls.Add(textBox_AgencyProvince);
            Controls.Add(textBox_AgencyCity);
            Controls.Add(textBox_AgencyAddress);
            Controls.Add(textBox_AgencyID1);
            Controls.Add(label2);
            Controls.Add(button_AgenciesBack);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdminGUI";
            Text = "Admin Dashboard";
            Load += FrmAdminGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label label1;
        private Button button_AgenciesBack;
        //private Button button_AgencyForward;
        private Label label2;
        private TextBox textBox_AgencyID1;
        private TextBox textBox_AgencyAddress;
        private TextBox textBox_AgencyCity;
        private TextBox textBox_AgencyProvince;
        private TextBox textBox_AgencyBusPhone;
        private TextBox textBox_AgencyCountry;
        private TextBox textBox_AgencyPostal;
        private TextBox textBox_AgentPosition;
        private TextBox textBox_AgentEmail;
        private TextBox textBox_AgentBussPhone;
        private TextBox textBox_AgentLName;
        private TextBox textBox_AgentMInitial;
        private TextBox textBox_AgentFName;
        private Button button_AgencyAdd;
        private Button button_AgencyEdit;
        private Button button_AgencyDelete;
        private Button button_AgentDelete;
        private Button button_AgentEdit;
        private Button button_AgentAdd;
        private Label label3;
        private Button button_AgentForward;
        private Button button_AgentBack;
        private Label label4;
        private TextBox textBox_AgentID;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox_AgencyFaxPhone;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Panel panel1;
        private TextBox textBox_AgencyID2;
        private Button button_AgenciesForward;
    }
}
