namespace TravelExperts.Views
{
    partial class PackageForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_PkgName = new TextBox();
            Pick_StartDate = new DateTimePicker();
            Pick_EndDate = new DateTimePicker();
            txt_PkgDesc = new TextBox();
            txt_BasePrice = new TextBox();
            txt_AgencyCommission = new TextBox();
            btn_Ok = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 90);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Package Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 131);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 1;
            label2.Text = "Package StartDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 173);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 2;
            label3.Text = "Package EndDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 213);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 3;
            label4.Text = "Package Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 252);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 4;
            label5.Text = "Package BasePrice:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 288);
            label6.Name = "label6";
            label6.Size = new Size(177, 17);
            label6.TabIndex = 5;
            label6.Text = "Package AgencyCommission:";
            // 
            // txt_PkgName
            // 
            txt_PkgName.Location = new Point(184, 87);
            txt_PkgName.Name = "txt_PkgName";
            txt_PkgName.Size = new Size(296, 23);
            txt_PkgName.TabIndex = 6;
            txt_PkgName.Tag = "PkgName";
            // 
            // Pick_StartDate
            // 
            Pick_StartDate.Location = new Point(184, 128);
            Pick_StartDate.Name = "Pick_StartDate";
            Pick_StartDate.Size = new Size(296, 23);
            Pick_StartDate.TabIndex = 7;
            Pick_StartDate.Tag = "PkgStartDate";
            // 
            // Pick_EndDate
            // 
            Pick_EndDate.Location = new Point(184, 168);
            Pick_EndDate.Name = "Pick_EndDate";
            Pick_EndDate.Size = new Size(296, 23);
            Pick_EndDate.TabIndex = 8;
            Pick_EndDate.Tag = "PkgEndDate";
            // 
            // txt_PkgDesc
            // 
            txt_PkgDesc.Location = new Point(184, 211);
            txt_PkgDesc.Name = "txt_PkgDesc";
            txt_PkgDesc.Size = new Size(296, 23);
            txt_PkgDesc.TabIndex = 9;
            txt_PkgDesc.Tag = "PkgDesc";
            // 
            // txt_BasePrice
            // 
            txt_BasePrice.Location = new Point(184, 249);
            txt_BasePrice.Name = "txt_BasePrice";
            txt_BasePrice.Size = new Size(296, 23);
            txt_BasePrice.TabIndex = 10;
            txt_BasePrice.Tag = "PkgBasePrice";
            // 
            // txt_AgencyCommission
            // 
            txt_AgencyCommission.Location = new Point(231, 285);
            txt_AgencyCommission.Name = "txt_AgencyCommission";
            txt_AgencyCommission.Size = new Size(249, 23);
            txt_AgencyCommission.TabIndex = 11;
            txt_AgencyCommission.Tag = "PkgAgencyCommission";
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(173, 358);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 12;
            btn_Ok.Text = "OK";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(327, 358);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(592, 450);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(txt_AgencyCommission);
            Controls.Add(txt_BasePrice);
            Controls.Add(txt_PkgDesc);
            Controls.Add(Pick_EndDate);
            Controls.Add(Pick_StartDate);
            Controls.Add(txt_PkgName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PackageForm";
            Text = "PackageForm";
            Load += PackageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_PkgName;
        private DateTimePicker Pick_StartDate;
        private DateTimePicker Pick_EndDate;
        private TextBox txt_PkgDesc;
        private TextBox txt_BasePrice;
        private TextBox txt_AgencyCommission;
        private Button btn_Ok;
        private Button btn_Cancel;
    }
}