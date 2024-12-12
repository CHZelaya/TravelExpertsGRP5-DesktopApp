namespace TravelExperts.Views
{
    partial class PackageMaintenance
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
            packageList = new DataGridView();
            btn_GetPackages = new Button();
            btn_Add = new Button();
            label1 = new Label();
            txt_pkgName = new TextBox();
            Start_Date = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            End_Date = new DateTimePicker();
            label4 = new Label();
            txt_BasePrice = new TextBox();
            btn_Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)packageList).BeginInit();
            SuspendLayout();
            // 
            // packageList
            // 
            packageList.AccessibleRole = AccessibleRole.None;
            packageList.BackgroundColor = Color.FromArgb(100, 166, 100);
            packageList.BorderStyle = BorderStyle.Fixed3D;
            packageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packageList.Location = new Point(12, 80);
            packageList.Name = "packageList";
            packageList.RowHeadersWidth = 51;
            packageList.Size = new Size(1081, 388);
            packageList.TabIndex = 0;
            packageList.CellContentClick += packageList_CellContentClick;
            // 
            // btn_GetPackages
            // 
            btn_GetPackages.BackColor = Color.LightGreen;
            btn_GetPackages.FlatStyle = FlatStyle.Flat;
            btn_GetPackages.Location = new Point(1016, 12);
            btn_GetPackages.Name = "btn_GetPackages";
            btn_GetPackages.Size = new Size(75, 30);
            btn_GetPackages.TabIndex = 1;
            btn_GetPackages.Text = "Search";
            btn_GetPackages.UseVisualStyleBackColor = false;
            btn_GetPackages.Click += btn_GetPackages_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.LightGreen;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Location = new Point(12, 12);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(98, 30);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "AddPackage";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 3;
            label1.Text = "Package Name:";
            // 
            // txt_pkgName
            // 
            txt_pkgName.Location = new Point(221, 14);
            txt_pkgName.Name = "txt_pkgName";
            txt_pkgName.Size = new Size(164, 23);
            txt_pkgName.TabIndex = 4;
            // 
            // Start_Date
            // 
            Start_Date.Checked = false;
            Start_Date.Location = new Point(462, 14);
            Start_Date.Name = "Start_Date";
            Start_Date.Size = new Size(137, 23);
            Start_Date.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 16);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 6;
            label2.Text = "StartDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 16);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 7;
            label3.Text = "EndDate:";
            // 
            // End_Date
            // 
            End_Date.Checked = false;
            End_Date.Location = new Point(671, 14);
            End_Date.Name = "End_Date";
            End_Date.Size = new Size(137, 23);
            End_Date.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(814, 19);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 9;
            label4.Text = "BasePrice:";
            // 
            // txt_BasePrice
            // 
            txt_BasePrice.Location = new Point(887, 16);
            txt_BasePrice.Name = "txt_BasePrice";
            txt_BasePrice.Size = new Size(123, 23);
            txt_BasePrice.TabIndex = 10;
            txt_BasePrice.Tag = "BasePrice";
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.LightGreen;
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Location = new Point(1016, 43);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(75, 30);
            btn_Reset.TabIndex = 11;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // PackageMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 493);
            Controls.Add(btn_Reset);
            Controls.Add(txt_BasePrice);
            Controls.Add(label4);
            Controls.Add(End_Date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Start_Date);
            Controls.Add(txt_pkgName);
            Controls.Add(label1);
            Controls.Add(btn_Add);
            Controls.Add(btn_GetPackages);
            Controls.Add(packageList);
            Name = "PackageMaintenance";
            Text = "PackageMaintenance";
            TransparencyKey = Color.LightGreen;
            Load += PackageMaintenance_Load;
            KeyDown += PackageMaintenance_KeyDown;
            ((System.ComponentModel.ISupportInitialize)packageList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView packageList;
        private Button btn_GetPackages;
        private Button btn_Add;
        private Label label1;
        private TextBox txt_pkgName;
        private DateTimePicker Start_Date;
        private Label label2;
        private Label label3;
        private DateTimePicker End_Date;
        private Label label4;
        private TextBox txt_BasePrice;
        private Button btn_Reset;
    }
}