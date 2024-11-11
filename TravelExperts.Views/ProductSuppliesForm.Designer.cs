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
            travelServicesLB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            supplierLB = new ListBox();
            searchTB = new TextBox();
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
            label2.Size = new Size(89, 19);
            label2.TabIndex = 3;
            label2.Text = "Offered By:";
            // 
            // supplierLB
            // 
            supplierLB.FormattingEnabled = true;
            supplierLB.ItemHeight = 15;
            supplierLB.Location = new Point(217, 133);
            supplierLB.Name = "supplierLB";
            supplierLB.Size = new Size(172, 244);
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
            // ProductSuppliesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchTB);
            Controls.Add(label2);
            Controls.Add(supplierLB);
            Controls.Add(label1);
            Controls.Add(travelServicesLB);
            Name = "ProductSuppliesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Suppliers Main Form";
            WindowState = FormWindowState.Maximized;
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
    }
}