namespace TravelExperts.Views
{
    partial class frmAdminGUIAgents
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
            textBox_AgencyID2 = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBox_AgentID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button_AgentForward = new Button();
            button_AgentBack = new Button();
            label4 = new Label();
            button_AgentDelete = new Button();
            button_AgentEdit = new Button();
            button_AgentAdd = new Button();
            textBox_AgentPosition = new TextBox();
            textBox_AgentEmail = new TextBox();
            textBox_AgentBussPhone = new TextBox();
            textBox_AgentLName = new TextBox();
            textBox_AgentMInitial = new TextBox();
            textBox_AgentFName = new TextBox();
            SuspendLayout();
            // 
            // textBox_AgencyID2
            // 
            textBox_AgencyID2.Location = new Point(621, 62);
            textBox_AgencyID2.Margin = new Padding(3, 2, 3, 2);
            textBox_AgencyID2.Name = "textBox_AgencyID2";
            textBox_AgencyID2.ReadOnly = true;
            textBox_AgencyID2.Size = new Size(35, 23);
            textBox_AgencyID2.TabIndex = 122;
            textBox_AgencyID2.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(432, 141);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 121;
            label18.Text = "Position";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(253, 195);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 120;
            label17.Text = "Email";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(253, 141);
            label16.Name = "label16";
            label16.Size = new Size(92, 15);
            label16.TabIndex = 119;
            label16.Text = "Business Phone ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(612, 96);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 118;
            label15.Text = "Last Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(432, 95);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 117;
            label14.Text = "Middle Initial";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(254, 94);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 116;
            label13.Text = "First Name";
            // 
            // textBox_AgentID
            // 
            textBox_AgentID.Location = new Point(732, 63);
            textBox_AgentID.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentID.Name = "textBox_AgentID";
            textBox_AgentID.ReadOnly = true;
            textBox_AgentID.Size = new Size(35, 23);
            textBox_AgentID.TabIndex = 115;
            textBox_AgentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(668, 71);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 114;
            label5.Text = "Agent ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(548, 70);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 113;
            label3.Text = "Agency ID :";
            // 
            // button_AgentForward
            // 
            button_AgentForward.Location = new Point(306, 62);
            button_AgentForward.Margin = new Padding(3, 2, 3, 2);
            button_AgentForward.Name = "button_AgentForward";
            button_AgentForward.Size = new Size(45, 24);
            button_AgentForward.TabIndex = 112;
            button_AgentForward.Text = ">";
            button_AgentForward.UseVisualStyleBackColor = true;
            // 
            // button_AgentBack
            // 
            button_AgentBack.Location = new Point(253, 61);
            button_AgentBack.Margin = new Padding(3, 2, 3, 2);
            button_AgentBack.Name = "button_AgentBack";
            button_AgentBack.Size = new Size(47, 24);
            button_AgentBack.TabIndex = 111;
            button_AgentBack.Text = "<";
            button_AgentBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(254, 18);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 110;
            label4.Text = "Agents";
            // 
            // button_AgentDelete
            // 
            button_AgentDelete.Cursor = Cursors.Hand;
            button_AgentDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_AgentDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button_AgentDelete.FlatStyle = FlatStyle.Flat;
            button_AgentDelete.Location = new Point(615, 249);
            button_AgentDelete.Margin = new Padding(3, 2, 3, 2);
            button_AgentDelete.Name = "button_AgentDelete";
            button_AgentDelete.Size = new Size(152, 36);
            button_AgentDelete.TabIndex = 109;
            button_AgentDelete.Text = "Delete Agent";
            button_AgentDelete.UseVisualStyleBackColor = true;
            // 
            // button_AgentEdit
            // 
            button_AgentEdit.Cursor = Cursors.Hand;
            button_AgentEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button_AgentEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            button_AgentEdit.FlatStyle = FlatStyle.Flat;
            button_AgentEdit.Location = new Point(433, 249);
            button_AgentEdit.Margin = new Padding(3, 2, 3, 2);
            button_AgentEdit.Name = "button_AgentEdit";
            button_AgentEdit.Size = new Size(152, 36);
            button_AgentEdit.TabIndex = 108;
            button_AgentEdit.Text = "Edit Agent";
            button_AgentEdit.UseVisualStyleBackColor = true;
            // 
            // button_AgentAdd
            // 
            button_AgentAdd.Cursor = Cursors.Hand;
            button_AgentAdd.FlatAppearance.MouseDownBackColor = Color.Lime;
            button_AgentAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button_AgentAdd.FlatStyle = FlatStyle.Flat;
            button_AgentAdd.Location = new Point(254, 249);
            button_AgentAdd.Margin = new Padding(3, 2, 3, 2);
            button_AgentAdd.Name = "button_AgentAdd";
            button_AgentAdd.Size = new Size(152, 36);
            button_AgentAdd.TabIndex = 107;
            button_AgentAdd.Text = "Add Agent";
            button_AgentAdd.UseVisualStyleBackColor = true;
            // 
            // textBox_AgentPosition
            // 
            textBox_AgentPosition.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentPosition.Location = new Point(432, 156);
            textBox_AgentPosition.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentPosition.Name = "textBox_AgentPosition";
            textBox_AgentPosition.ReadOnly = true;
            textBox_AgentPosition.Size = new Size(153, 23);
            textBox_AgentPosition.TabIndex = 106;
            // 
            // textBox_AgentEmail
            // 
            textBox_AgentEmail.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentEmail.Location = new Point(253, 212);
            textBox_AgentEmail.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentEmail.Name = "textBox_AgentEmail";
            textBox_AgentEmail.ReadOnly = true;
            textBox_AgentEmail.Size = new Size(191, 23);
            textBox_AgentEmail.TabIndex = 105;
            // 
            // textBox_AgentBussPhone
            // 
            textBox_AgentBussPhone.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentBussPhone.Location = new Point(253, 158);
            textBox_AgentBussPhone.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentBussPhone.Name = "textBox_AgentBussPhone";
            textBox_AgentBussPhone.ReadOnly = true;
            textBox_AgentBussPhone.Size = new Size(153, 23);
            textBox_AgentBussPhone.TabIndex = 104;
            // 
            // textBox_AgentLName
            // 
            textBox_AgentLName.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentLName.Location = new Point(614, 112);
            textBox_AgentLName.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentLName.Name = "textBox_AgentLName";
            textBox_AgentLName.ReadOnly = true;
            textBox_AgentLName.Size = new Size(153, 23);
            textBox_AgentLName.TabIndex = 103;
            // 
            // textBox_AgentMInitial
            // 
            textBox_AgentMInitial.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentMInitial.Location = new Point(432, 112);
            textBox_AgentMInitial.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentMInitial.Name = "textBox_AgentMInitial";
            textBox_AgentMInitial.ReadOnly = true;
            textBox_AgentMInitial.Size = new Size(153, 23);
            textBox_AgentMInitial.TabIndex = 102;
            // 
            // textBox_AgentFName
            // 
            textBox_AgentFName.BorderStyle = BorderStyle.FixedSingle;
            textBox_AgentFName.Location = new Point(253, 112);
            textBox_AgentFName.Margin = new Padding(3, 2, 3, 2);
            textBox_AgentFName.Name = "textBox_AgentFName";
            textBox_AgentFName.ReadOnly = true;
            textBox_AgentFName.Size = new Size(153, 23);
            textBox_AgentFName.TabIndex = 101;
            // 
            // frmAdminGUIAgents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_AgencyID2);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox_AgentID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button_AgentForward);
            Controls.Add(button_AgentBack);
            Controls.Add(label4);
            Controls.Add(button_AgentDelete);
            Controls.Add(button_AgentEdit);
            Controls.Add(button_AgentAdd);
            Controls.Add(textBox_AgentPosition);
            Controls.Add(textBox_AgentEmail);
            Controls.Add(textBox_AgentBussPhone);
            Controls.Add(textBox_AgentLName);
            Controls.Add(textBox_AgentMInitial);
            Controls.Add(textBox_AgentFName);
            Name = "frmAdminGUIAgents";
            Text = "frmAdminGUIAgents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_AgencyID2;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox textBox_AgentID;
        private Label label5;
        private Label label3;
        private Button button_AgentForward;
        private Button button_AgentBack;
        private Label label4;
        private Button button_AgentDelete;
        private Button button_AgentEdit;
        private Button button_AgentAdd;
        private TextBox textBox_AgentPosition;
        private TextBox textBox_AgentEmail;
        private TextBox textBox_AgentBussPhone;
        private TextBox textBox_AgentLName;
        private TextBox textBox_AgentMInitial;
        private TextBox textBox_AgentFName;
    }
}