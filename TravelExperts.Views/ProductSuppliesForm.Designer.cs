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
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            addBtn = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            updateBtn = new Button();
            deleteBtn = new Button();
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
            supplierLB.Size = new Size(344, 244);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(739, 277);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 5;
            label3.Text = "Suppliers:";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(822, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Times New Roman", 12F);
            addBtn.Location = new Point(567, 177);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(123, 41);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add New";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(822, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(715, 170);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 10;
            label4.Text = "Travel Services:";
            label4.Visible = false;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Times New Roman", 12F);
            updateBtn.Location = new Point(567, 255);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(123, 41);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update Existing";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 12F);
            deleteBtn.Location = new Point(567, 322);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(123, 41);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete Existing";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // ProductSuppliesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 488);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(addBtn);
            Controls.Add(textBox1);
            Controls.Add(label3);
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
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Button addBtn;
        private ComboBox comboBox1;
        private Label label4;
        private Button updateBtn;
        private Button deleteBtn;
    }
}