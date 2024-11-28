namespace TravelExperts.Views
{
    partial class ProductSuppliesForm
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
            components = new System.ComponentModel.Container();
            travelServicesLB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            supplierLB = new ListBox();
            searchTB = new TextBox();
            suppliersLbl = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            suppliersTB = new TextBox();
            addUpdateBtn = new Button();
            travelServiceLbl = new Label();
            deleteBtn = new Button();
            saveBtn = new Button();
            resetBtn = new Button();
            travelServicesCBx = new ComboBox();
            hiddenLblSupID = new Label();
            SuspendLayout();
            // 
            // travelServicesLB
            // 
            travelServicesLB.FormattingEnabled = true;
            travelServicesLB.ItemHeight = 15;
            travelServicesLB.Location = new Point(29, 133);
            travelServicesLB.Name = "travelServicesLB";
            travelServicesLB.Size = new Size(172, 244);
            travelServicesLB.TabIndex = 0;
            travelServicesLB.SelectedIndexChanged += travelServicesLB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 111);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 1;
            label1.Text = "Travel Services:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 111);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Suppliers:";
            // 
            // supplierLB
            // 
            supplierLB.FormattingEnabled = true;
            supplierLB.ItemHeight = 15;
            supplierLB.Location = new Point(217, 133);
            supplierLB.Name = "supplierLB";
            supplierLB.Size = new Size(314, 244);
            supplierLB.TabIndex = 2;
            // 
            // searchTB
            // 
            searchTB.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            searchTB.Location = new Point(217, 29);
            searchTB.Name = "searchTB";
            searchTB.PlaceholderText = "Search by products or supplies";
            searchTB.Size = new Size(253, 26);
            searchTB.TabIndex = 4;
            searchTB.KeyUp += searchTB_KeyUp;
            // 
            // suppliersLbl
            // 
            suppliersLbl.AutoSize = true;
            suppliersLbl.Font = new Font("Times New Roman", 12F);
            suppliersLbl.Location = new Point(687, 278);
            suppliersLbl.Name = "suppliersLbl";
            suppliersLbl.Size = new Size(68, 19);
            suppliersLbl.TabIndex = 5;
            suppliersLbl.Text = "Suppliers:";
            suppliersLbl.Visible = false;
            suppliersLbl.Click += label3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // suppliersTB
            // 
            suppliersTB.Font = new Font("Times New Roman", 12F);
            suppliersTB.Location = new Point(816, 271);
            suppliersTB.Name = "suppliersTB";
            suppliersTB.Size = new Size(204, 26);
            suppliersTB.TabIndex = 7;
            suppliersTB.Visible = false;
            // 
            // addUpdateBtn
            // 
            addUpdateBtn.Font = new Font("Times New Roman", 12F);
            addUpdateBtn.Location = new Point(546, 173);
            addUpdateBtn.Name = "addUpdateBtn";
            addUpdateBtn.Size = new Size(123, 41);
            addUpdateBtn.TabIndex = 8;
            addUpdateBtn.Text = "Add/Update";
            addUpdateBtn.UseVisualStyleBackColor = true;
            addUpdateBtn.Click += addBtn_Click;
            // 
            // travelServiceLbl
            // 
            travelServiceLbl.AutoSize = true;
            travelServiceLbl.Font = new Font("Times New Roman", 12F);
            travelServiceLbl.Location = new Point(687, 173);
            travelServiceLbl.Name = "travelServiceLbl";
            travelServiceLbl.Size = new Size(104, 19);
            travelServiceLbl.TabIndex = 10;
            travelServiceLbl.Text = "Travel Services:";
            travelServiceLbl.Visible = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 12F);
            deleteBtn.Location = new Point(546, 318);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(123, 41);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete Existing";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Times New Roman", 12F);
            saveBtn.Location = new Point(790, 336);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(83, 27);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Times New Roman", 12F);
            resetBtn.Location = new Point(879, 336);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(83, 27);
            resetBtn.TabIndex = 15;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // travelServicesCBx
            // 
            travelServicesCBx.DropDownStyle = ComboBoxStyle.DropDownList;
            travelServicesCBx.Location = new Point(816, 169);
            travelServicesCBx.Margin = new Padding(3, 2, 3, 2);
            travelServicesCBx.Name = "travelServicesCBx";
            travelServicesCBx.Size = new Size(151, 23);
            travelServicesCBx.TabIndex = 16;
            travelServicesCBx.Visible = false;
            // 
            // hiddenLblSupID
            // 
            hiddenLblSupID.AutoSize = true;
            hiddenLblSupID.Location = new Point(739, 93);
            hiddenLblSupID.Name = "hiddenLblSupID";
            hiddenLblSupID.Size = new Size(0, 15);
            hiddenLblSupID.TabIndex = 17;
            hiddenLblSupID.Visible = false;
            // 
            // ProductSuppliesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 488);
            Controls.Add(hiddenLblSupID);
            Controls.Add(travelServicesCBx);
            Controls.Add(resetBtn);
            Controls.Add(saveBtn);
            Controls.Add(deleteBtn);
            Controls.Add(travelServiceLbl);
            Controls.Add(addUpdateBtn);
            Controls.Add(suppliersTB);
            Controls.Add(suppliersLbl);
            Controls.Add(searchTB);
            Controls.Add(label2);
            Controls.Add(supplierLB);
            Controls.Add(label1);
            Controls.Add(travelServicesLB);
            Name = "ProductSuppliesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Suppliers Main Form";
            Load += ProductSuppliesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox travelServicesLB;
        private Label label1;
        private Label label2;
        private ListBox supplierLB;
        private TextBox searchTB;
        private Label suppliersLbl;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox suppliersTB;
        private Button addUpdateBtn;
        private Label travelServiceLbl;
        private Button deleteBtn;
        private Button saveBtn;
        private Button resetBtn;
        private ComboBox travelServicesCBx;
        private Label hiddenLblSupID;
    }
}