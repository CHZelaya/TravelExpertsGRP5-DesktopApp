


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
            components = new System.ComponentModel.Container();
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
            button_AgencyAdd = new Button();
            button_AgencyEdit = new Button();
            button_AgencyDelete = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox_AgencyFaxPhone = new TextBox();
            panel1 = new Panel();
            button_AgenciesForward = new Button();
            dataGridView1 = new DataGridView();
            agentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtFirstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtMiddleInitialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtLastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtBusPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agtPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agencyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agencyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agentStatusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            agentBindingSource = new BindingSource(components);
            agentsAndAgenciesControllersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agentsAndAgenciesControllersBindingSource).BeginInit();
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
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(427, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Agency ID :";
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
            textBox_AgencyAddress.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyAddress.Location = new Point(21, 109);
            textBox_AgencyAddress.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyAddress.Name = "textBox_AgencyAddress";
            textBox_AgencyAddress.ReadOnly = true;
            textBox_AgencyAddress.Size = new Size(153, 23);
            textBox_AgencyAddress.TabIndex = 6;
            // 
            // textBox_AgencyCity
            // 
            textBox_AgencyCity.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyCity.Location = new Point(200, 109);
            textBox_AgencyCity.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyCity.Name = "textBox_AgencyCity";
            textBox_AgencyCity.ReadOnly = true;
            textBox_AgencyCity.Size = new Size(153, 23);
            textBox_AgencyCity.TabIndex = 7;
            // 
            // textBox_AgencyProvince
            // 
            textBox_AgencyProvince.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyProvince.Location = new Point(382, 109);
            textBox_AgencyProvince.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyProvince.Name = "textBox_AgencyProvince";
            textBox_AgencyProvince.ReadOnly = true;
            textBox_AgencyProvince.Size = new Size(153, 23);
            textBox_AgencyProvince.TabIndex = 8;
            // 
            // textBox_AgencyBusPhone
            // 
            textBox_AgencyBusPhone.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyBusPhone.Location = new Point(382, 156);
            textBox_AgencyBusPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyBusPhone.Name = "textBox_AgencyBusPhone";
            textBox_AgencyBusPhone.ReadOnly = true;
            textBox_AgencyBusPhone.Size = new Size(153, 23);
            textBox_AgencyBusPhone.TabIndex = 11;
            // 
            // textBox_AgencyCountry
            // 
            textBox_AgencyCountry.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyCountry.Location = new Point(200, 156);
            textBox_AgencyCountry.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyCountry.Name = "textBox_AgencyCountry";
            textBox_AgencyCountry.ReadOnly = true;
            textBox_AgencyCountry.Size = new Size(153, 23);
            textBox_AgencyCountry.TabIndex = 10;
            // 
            // textBox_AgencyPostal
            // 
            textBox_AgencyPostal.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyPostal.Location = new Point(21, 156);
            textBox_AgencyPostal.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyPostal.Name = "textBox_AgencyPostal";
            textBox_AgencyPostal.ReadOnly = true;
            textBox_AgencyPostal.Size = new Size(153, 23);
            textBox_AgencyPostal.TabIndex = 9;
            // 
            // button_AgencyAdd
            // 
            button_AgencyAdd.Cursor = Cursors.Hand;
            button_AgencyAdd.FlatAppearance.BorderColor = Color.Black;
            button_AgencyAdd.FlatAppearance.MouseDownBackColor = Color.Lime;
            button_AgencyAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button_AgencyAdd.FlatStyle = FlatStyle.Flat;
            button_AgencyAdd.Location = new Point(21, 231);
            button_AgencyAdd.Margin = new Padding(3, 2, 3, 2);
            button_AgencyAdd.Name = "button_AgencyAdd";
            button_AgencyAdd.Size = new Size(152, 36);
            button_AgencyAdd.TabIndex = 18;
            button_AgencyAdd.Text = "Add Agency";
            button_AgencyAdd.UseVisualStyleBackColor = true;
            button_AgencyAdd.Click += button_AgencyAdd_Click;
            // 
            // button_AgencyEdit
            // 
            button_AgencyEdit.Cursor = Cursors.Hand;
            button_AgencyEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_AgencyEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_AgencyEdit.FlatStyle = FlatStyle.Flat;
            button_AgencyEdit.Location = new Point(200, 231);
            button_AgencyEdit.Margin = new Padding(3, 2, 3, 2);
            button_AgencyEdit.Name = "button_AgencyEdit";
            button_AgencyEdit.Size = new Size(152, 36);
            button_AgencyEdit.TabIndex = 19;
            button_AgencyEdit.Text = "Edit Agency";
            button_AgencyEdit.UseVisualStyleBackColor = true;
            button_AgencyEdit.Click += button_AgencyEdit_Click;
            // 
            // button_AgencyDelete
            // 
            button_AgencyDelete.Cursor = Cursors.Hand;
            button_AgencyDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_AgencyDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button_AgencyDelete.FlatStyle = FlatStyle.Flat;
            button_AgencyDelete.Location = new Point(382, 231);
            button_AgencyDelete.Margin = new Padding(3, 2, 3, 2);
            button_AgencyDelete.Name = "button_AgencyDelete";
            button_AgencyDelete.Size = new Size(152, 36);
            button_AgencyDelete.TabIndex = 20;
            button_AgencyDelete.Text = "Delete Agency";
            button_AgencyDelete.UseVisualStyleBackColor = true;
            button_AgencyDelete.Click += button_AgencyDelete_Click;
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
            textBox_AgencyFaxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgencyFaxPhone.Location = new Point(382, 196);
            textBox_AgencyFaxPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyFaxPhone.Name = "textBox_AgencyFaxPhone";
            textBox_AgencyFaxPhone.ReadOnly = true;
            textBox_AgencyFaxPhone.Size = new Size(153, 23);
            textBox_AgencyFaxPhone.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InfoText;
            panel1.Location = new Point(0, 333);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 10);
            panel1.TabIndex = 99;
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { agentIdDataGridViewTextBoxColumn, agtFirstNameDataGridViewTextBoxColumn, agtMiddleInitialDataGridViewTextBoxColumn, agtLastNameDataGridViewTextBoxColumn, agtBusPhoneDataGridViewTextBoxColumn, agtEmailDataGridViewTextBoxColumn, agtPositionDataGridViewTextBoxColumn, agencyIdDataGridViewTextBoxColumn, agencyDataGridViewTextBoxColumn, customersDataGridViewTextBoxColumn, agentStatusDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = agentBindingSource;
            dataGridView1.Location = new Point(647, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(581, 258);
            dataGridView1.TabIndex = 102;
            // 
            // agentIdDataGridViewTextBoxColumn
            // 
            agentIdDataGridViewTextBoxColumn.DataPropertyName = "AgentId";
            agentIdDataGridViewTextBoxColumn.HeaderText = "AgentId";
            agentIdDataGridViewTextBoxColumn.Name = "agentIdDataGridViewTextBoxColumn";
            // 
            // agtFirstNameDataGridViewTextBoxColumn
            // 
            agtFirstNameDataGridViewTextBoxColumn.DataPropertyName = "AgtFirstName";
            agtFirstNameDataGridViewTextBoxColumn.HeaderText = "AgtFirstName";
            agtFirstNameDataGridViewTextBoxColumn.Name = "agtFirstNameDataGridViewTextBoxColumn";
            // 
            // agtMiddleInitialDataGridViewTextBoxColumn
            // 
            agtMiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "AgtMiddleInitial";
            agtMiddleInitialDataGridViewTextBoxColumn.HeaderText = "AgtMiddleInitial";
            agtMiddleInitialDataGridViewTextBoxColumn.Name = "agtMiddleInitialDataGridViewTextBoxColumn";
            // 
            // agtLastNameDataGridViewTextBoxColumn
            // 
            agtLastNameDataGridViewTextBoxColumn.DataPropertyName = "AgtLastName";
            agtLastNameDataGridViewTextBoxColumn.HeaderText = "AgtLastName";
            agtLastNameDataGridViewTextBoxColumn.Name = "agtLastNameDataGridViewTextBoxColumn";
            // 
            // agtBusPhoneDataGridViewTextBoxColumn
            // 
            agtBusPhoneDataGridViewTextBoxColumn.DataPropertyName = "AgtBusPhone";
            agtBusPhoneDataGridViewTextBoxColumn.HeaderText = "AgtBusPhone";
            agtBusPhoneDataGridViewTextBoxColumn.Name = "agtBusPhoneDataGridViewTextBoxColumn";
            // 
            // agtEmailDataGridViewTextBoxColumn
            // 
            agtEmailDataGridViewTextBoxColumn.DataPropertyName = "AgtEmail";
            agtEmailDataGridViewTextBoxColumn.HeaderText = "AgtEmail";
            agtEmailDataGridViewTextBoxColumn.Name = "agtEmailDataGridViewTextBoxColumn";
            // 
            // agtPositionDataGridViewTextBoxColumn
            // 
            agtPositionDataGridViewTextBoxColumn.DataPropertyName = "AgtPosition";
            agtPositionDataGridViewTextBoxColumn.HeaderText = "AgtPosition";
            agtPositionDataGridViewTextBoxColumn.Name = "agtPositionDataGridViewTextBoxColumn";
            // 
            // agencyIdDataGridViewTextBoxColumn
            // 
            agencyIdDataGridViewTextBoxColumn.DataPropertyName = "AgencyId";
            agencyIdDataGridViewTextBoxColumn.HeaderText = "AgencyId";
            agencyIdDataGridViewTextBoxColumn.Name = "agencyIdDataGridViewTextBoxColumn";
            // 
            // agencyDataGridViewTextBoxColumn
            // 
            agencyDataGridViewTextBoxColumn.DataPropertyName = "Agency";
            agencyDataGridViewTextBoxColumn.HeaderText = "Agency";
            agencyDataGridViewTextBoxColumn.Name = "agencyDataGridViewTextBoxColumn";
            // 
            // customersDataGridViewTextBoxColumn
            // 
            customersDataGridViewTextBoxColumn.DataPropertyName = "Customers";
            customersDataGridViewTextBoxColumn.HeaderText = "Customers";
            customersDataGridViewTextBoxColumn.Name = "customersDataGridViewTextBoxColumn";
            // 
            // agentStatusDataGridViewCheckBoxColumn
            // 
            agentStatusDataGridViewCheckBoxColumn.DataPropertyName = "AgentStatus";
            agentStatusDataGridViewCheckBoxColumn.HeaderText = "AgentStatus";
            agentStatusDataGridViewCheckBoxColumn.Name = "agentStatusDataGridViewCheckBoxColumn";
            // 
            // agentBindingSource
            // 
            agentBindingSource.DataSource = typeof(Models.Models.Agent);
            // 
            // agentsAndAgenciesControllersBindingSource
            // 
            agentsAndAgenciesControllersBindingSource.DataSource = typeof(Controllers.AgentsAndAgenciesControllers);
            // 
            // frmAdminGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1273, 701);
            Controls.Add(dataGridView1);
            Controls.Add(button_AgenciesForward);
            Controls.Add(panel1);
            Controls.Add(textBox_AgencyFaxPhone);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button_AgencyDelete);
            Controls.Add(button_AgencyEdit);
            Controls.Add(button_AgencyAdd);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdminGUI";
            Text = "Admin Dashboard";
            Load += FrmAdminGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)agentsAndAgenciesControllersBindingSource).EndInit();
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
        private Button button_AgencyAdd;
        private Button button_AgencyEdit;
        private Button button_AgencyDelete;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox_AgencyFaxPhone;
        private Panel panel1;
        private Button button_AgenciesForward;
        private DataGridView dataGridView1;
        private BindingSource agentsAndAgenciesControllersBindingSource;
        private DataGridViewTextBoxColumn agentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtFirstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtMiddleInitialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtBusPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agtPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agencyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agencyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customersDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn agentStatusDataGridViewCheckBoxColumn;
        private BindingSource agentBindingSource;
    }
}
