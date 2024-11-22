
namespace TravelExperts.Views
{
    partial class frmAdminAgenciesManagement
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
            groupBox1 = new GroupBox();
            textBox_AgencyFaxPhone = new TextBox();
            label7 = new Label();
            button_Cancel = new Button();
            button_OK = new Button();
            textBox_AgencyBusPhone = new TextBox();
            textBox_AgencyCountry = new TextBox();
            textBox_AgencyPostal = new TextBox();
            textBox_AgencyProvince = new TextBox();
            textBox_AgencyCity = new TextBox();
            textBox_AgencyAddress = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_AgenciesTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_AgencyFaxPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button_Cancel);
            groupBox1.Controls.Add(button_OK);
            groupBox1.Controls.Add(textBox_AgencyBusPhone);
            groupBox1.Controls.Add(textBox_AgencyCountry);
            groupBox1.Controls.Add(textBox_AgencyPostal);
            groupBox1.Controls.Add(textBox_AgencyProvince);
            groupBox1.Controls.Add(textBox_AgencyCity);
            groupBox1.Controls.Add(textBox_AgencyAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(113, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 287);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agency Details";
            // 
            // textBox_AgencyFaxPhone
            // 
            textBox_AgencyFaxPhone.Location = new Point(110, 249);
            textBox_AgencyFaxPhone.Name = "textBox_AgencyFaxPhone";
            textBox_AgencyFaxPhone.Size = new Size(202, 23);
            textBox_AgencyFaxPhone.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 252);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 13;
            label7.Text = "Fax :";
            // 
            // button_Cancel
            // 
            button_Cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button_Cancel.FlatStyle = FlatStyle.Flat;
            button_Cancel.Location = new Point(363, 184);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(104, 57);
            button_Cancel.TabIndex = 12;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            button_OK.FlatAppearance.MouseDownBackColor = Color.Lime;
            button_OK.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button_OK.FlatStyle = FlatStyle.Flat;
            button_OK.Location = new Point(363, 85);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(104, 57);
            button_OK.TabIndex = 2;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // textBox_AgencyBusPhone
            // 
            textBox_AgencyBusPhone.Location = new Point(110, 210);
            textBox_AgencyBusPhone.Name = "textBox_AgencyBusPhone";
            textBox_AgencyBusPhone.Size = new Size(202, 23);
            textBox_AgencyBusPhone.TabIndex = 11;
            // 
            // textBox_AgencyCountry
            // 
            textBox_AgencyCountry.Location = new Point(110, 172);
            textBox_AgencyCountry.Name = "textBox_AgencyCountry";
            textBox_AgencyCountry.Size = new Size(202, 23);
            textBox_AgencyCountry.TabIndex = 10;
            // 
            // textBox_AgencyPostal
            // 
            textBox_AgencyPostal.Location = new Point(110, 135);
            textBox_AgencyPostal.Name = "textBox_AgencyPostal";
            textBox_AgencyPostal.Size = new Size(202, 23);
            textBox_AgencyPostal.TabIndex = 9;
            // 
            // textBox_AgencyProvince
            // 
            textBox_AgencyProvince.Location = new Point(110, 103);
            textBox_AgencyProvince.Name = "textBox_AgencyProvince";
            textBox_AgencyProvince.Size = new Size(202, 23);
            textBox_AgencyProvince.TabIndex = 8;
            // 
            // textBox_AgencyCity
            // 
            textBox_AgencyCity.Location = new Point(110, 69);
            textBox_AgencyCity.Name = "textBox_AgencyCity";
            textBox_AgencyCity.Size = new Size(202, 23);
            textBox_AgencyCity.TabIndex = 7;
            // 
            // textBox_AgencyAddress
            // 
            textBox_AgencyAddress.Location = new Point(110, 34);
            textBox_AgencyAddress.Name = "textBox_AgencyAddress";
            textBox_AgencyAddress.Size = new Size(202, 23);
            textBox_AgencyAddress.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 218);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 5;
            label6.Text = "Bus. Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 180);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Country :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 143);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Postal Code :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 111);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Province :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 77);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "City :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Address :";
            // 
            // label_AgenciesTitle
            // 
            label_AgenciesTitle.AutoSize = true;
            label_AgenciesTitle.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_AgenciesTitle.Location = new Point(223, 48);
            label_AgenciesTitle.Name = "label_AgenciesTitle";
            label_AgenciesTitle.Size = new Size(62, 30);
            label_AgenciesTitle.TabIndex = 2;
            label_AgenciesTitle.Text = "Title";
            // 
            // frmAdminAgenciesManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(704, 454);
            Controls.Add(groupBox1);
            Controls.Add(label_AgenciesTitle);
            Name = "frmAdminAgenciesManagement";
            Text = "Admin Agencies Management";
            Load += frmAdminAgenciesManagement_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox groupBox1;
        private Button button_Cancel;
        private Button button_OK;
        private TextBox textBox_AgencyBusPhone;
        private TextBox textBox_AgencyCountry;
        private TextBox textBox_AgencyPostal;
        private TextBox textBox_AgencyProvince;
        private TextBox textBox_AgencyCity;
        private TextBox textBox_AgencyAddress;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label_AgenciesTitle;
        private TextBox textBox_AgencyFaxPhone;
        private Label label7;
    }
}