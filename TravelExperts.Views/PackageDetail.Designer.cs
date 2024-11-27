namespace TravelExperts.Views
{
    partial class PackageDetail
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
            txt_PkgName = new TextBox();
            label2 = new Label();
            txt_PkgDesc = new TextBox();
            label3 = new Label();
            txt_StartDate = new TextBox();
            label4 = new Label();
            txt_EndDate = new TextBox();
            label5 = new Label();
            txt_BasePrice = new TextBox();
            label6 = new Label();
            txt_AgencyCommission = new TextBox();
            PackageDetailList = new ListBox();
            btn_Cancel = new Button();
            txt_Add = new Button();
            btn_Remove = new Button();
            Select_ProductSupplier = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Pkg Name:";
            // 
            // txt_PkgName
            // 
            txt_PkgName.Enabled = false;
            txt_PkgName.Location = new Point(106, 20);
            txt_PkgName.Name = "txt_PkgName";
            txt_PkgName.ReadOnly = true;
            txt_PkgName.Size = new Size(380, 23);
            txt_PkgName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "Pkg Desc:";
            // 
            // txt_PkgDesc
            // 
            txt_PkgDesc.Enabled = false;
            txt_PkgDesc.Location = new Point(106, 57);
            txt_PkgDesc.Name = "txt_PkgDesc";
            txt_PkgDesc.ReadOnly = true;
            txt_PkgDesc.Size = new Size(380, 23);
            txt_PkgDesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 95);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 4;
            label3.Text = "Pkg StartDate:";
            // 
            // txt_StartDate
            // 
            txt_StartDate.Enabled = false;
            txt_StartDate.Location = new Point(125, 95);
            txt_StartDate.Name = "txt_StartDate";
            txt_StartDate.ReadOnly = true;
            txt_StartDate.Size = new Size(361, 23);
            txt_StartDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 6;
            label4.Text = "Pkg EndDate:";
            // 
            // txt_EndDate
            // 
            txt_EndDate.Enabled = false;
            txt_EndDate.Location = new Point(120, 128);
            txt_EndDate.Name = "txt_EndDate";
            txt_EndDate.ReadOnly = true;
            txt_EndDate.Size = new Size(366, 23);
            txt_EndDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 163);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 8;
            label5.Text = "Pkg BasePrice:";
            // 
            // txt_BasePrice
            // 
            txt_BasePrice.Enabled = false;
            txt_BasePrice.Location = new Point(127, 163);
            txt_BasePrice.Name = "txt_BasePrice";
            txt_BasePrice.ReadOnly = true;
            txt_BasePrice.Size = new Size(359, 23);
            txt_BasePrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 197);
            label6.Name = "label6";
            label6.Size = new Size(150, 17);
            label6.TabIndex = 10;
            label6.Text = "Pkg AgencyCommission:";
            // 
            // txt_AgencyCommission
            // 
            txt_AgencyCommission.Enabled = false;
            txt_AgencyCommission.Location = new Point(184, 197);
            txt_AgencyCommission.Name = "txt_AgencyCommission";
            txt_AgencyCommission.ReadOnly = true;
            txt_AgencyCommission.Size = new Size(302, 23);
            txt_AgencyCommission.TabIndex = 11;
            // 
            // PackageDetailList
            // 
            PackageDetailList.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PackageDetailList.ForeColor = SystemColors.WindowText;
            PackageDetailList.FormattingEnabled = true;
            PackageDetailList.ItemHeight = 14;
            PackageDetailList.Location = new Point(27, 255);
            PackageDetailList.Name = "PackageDetailList";
            PackageDetailList.Size = new Size(459, 88);
            PackageDetailList.TabIndex = 12;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(354, 447);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_Add
            // 
            txt_Add.Location = new Point(65, 447);
            txt_Add.Name = "txt_Add";
            txt_Add.Size = new Size(75, 23);
            txt_Add.TabIndex = 14;
            txt_Add.Text = "Add";
            txt_Add.UseVisualStyleBackColor = true;
            txt_Add.Click += txt_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(215, 447);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 23);
            btn_Remove.TabIndex = 15;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // Select_ProductSupplier
            // 
            Select_ProductSupplier.FormattingEnabled = true;
            Select_ProductSupplier.Location = new Point(142, 369);
            Select_ProductSupplier.Name = "Select_ProductSupplier";
            Select_ProductSupplier.Size = new Size(344, 25);
            Select_ProductSupplier.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 369);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 17;
            label7.Text = "Product_Supplier:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 232);
            label8.Name = "label8";
            label8.Size = new Size(88, 17);
            label8.TabIndex = 18;
            label8.Text = "ProductName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(241, 232);
            label9.Name = "label9";
            label9.Size = new Size(91, 17);
            label9.TabIndex = 19;
            label9.Text = "SupplierName";
            // 
            // PackageDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(518, 521);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Select_ProductSupplier);
            Controls.Add(btn_Remove);
            Controls.Add(txt_Add);
            Controls.Add(btn_Cancel);
            Controls.Add(PackageDetailList);
            Controls.Add(txt_AgencyCommission);
            Controls.Add(label6);
            Controls.Add(txt_BasePrice);
            Controls.Add(label5);
            Controls.Add(txt_EndDate);
            Controls.Add(label4);
            Controls.Add(txt_StartDate);
            Controls.Add(label3);
            Controls.Add(txt_PkgDesc);
            Controls.Add(label2);
            Controls.Add(txt_PkgName);
            Controls.Add(label1);
            Name = "PackageDetail";
            Text = "PackageDetail";
            Load += PackageDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_PkgName;
        private Label label2;
        private TextBox txt_PkgDesc;
        private Label label3;
        private TextBox txt_StartDate;
        private Label label4;
        private TextBox txt_EndDate;
        private Label label5;
        private TextBox txt_BasePrice;
        private Label label6;
        private TextBox txt_AgencyCommission;
        private ListBox PackageDetailList;
        private Button btn_Cancel;
        private Button txt_Add;
        private Button btn_Remove;
        private ComboBox Select_ProductSupplier;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}