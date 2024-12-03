namespace TravelExperts.Views
{
    partial class AdminGUIMain
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
            tableLayoutPanel_Bottom = new TableLayoutPanel();
            btn_Add = new Button();
            btn_Modify = new Button();
            btn_Delete = new Button();
            tableLayoutPanel_Top = new TableLayoutPanel();
            btn_Agents = new Button();
            btn_Agencies = new Button();
            panel_body = new Panel();
            dataGridView = new DataGridView();
            tableLayoutPanel_Bottom.SuspendLayout();
            tableLayoutPanel_Top.SuspendLayout();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel_Bottom
            // 
            tableLayoutPanel_Bottom.ColumnCount = 3;
            tableLayoutPanel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel_Bottom.Controls.Add(btn_Add, 0, 0);
            tableLayoutPanel_Bottom.Controls.Add(btn_Modify, 1, 0);
            tableLayoutPanel_Bottom.Controls.Add(btn_Delete, 2, 0);
            tableLayoutPanel_Bottom.Dock = DockStyle.Top;
            tableLayoutPanel_Bottom.Location = new Point(0, 75);
            tableLayoutPanel_Bottom.Name = "tableLayoutPanel_Bottom";
            tableLayoutPanel_Bottom.RowCount = 1;
            tableLayoutPanel_Bottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Bottom.Size = new Size(984, 75);
            tableLayoutPanel_Bottom.TabIndex = 8;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Fill;
            btn_Add.FlatAppearance.BorderColor = Color.SpringGreen;
            btn_Add.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Location = new Point(3, 3);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(322, 69);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Modify
            // 
            btn_Modify.Dock = DockStyle.Fill;
            btn_Modify.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btn_Modify.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            btn_Modify.FlatStyle = FlatStyle.Flat;
            btn_Modify.Location = new Point(331, 3);
            btn_Modify.Name = "btn_Modify";
            btn_Modify.Size = new Size(322, 69);
            btn_Modify.TabIndex = 3;
            btn_Modify.Text = "Modify";
            btn_Modify.UseVisualStyleBackColor = true;
            btn_Modify.Click += btn_Modify_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Fill;
            btn_Delete.FlatAppearance.BorderColor = Color.Red;
            btn_Delete.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Location = new Point(659, 3);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(322, 69);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // tableLayoutPanel_Top
            // 
            tableLayoutPanel_Top.ColumnCount = 2;
            tableLayoutPanel_Top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Top.Controls.Add(btn_Agents, 0, 0);
            tableLayoutPanel_Top.Controls.Add(btn_Agencies, 1, 0);
            tableLayoutPanel_Top.Dock = DockStyle.Top;
            tableLayoutPanel_Top.Location = new Point(0, 0);
            tableLayoutPanel_Top.Name = "tableLayoutPanel_Top";
            tableLayoutPanel_Top.RowCount = 1;
            tableLayoutPanel_Top.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Top.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Top.Size = new Size(984, 75);
            tableLayoutPanel_Top.TabIndex = 7;
            // 
            // btn_Agents
            // 
            btn_Agents.BackColor = Color.DodgerBlue;
            btn_Agents.Dock = DockStyle.Fill;
            btn_Agents.FlatStyle = FlatStyle.Flat;
            btn_Agents.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btn_Agents.ForeColor = Color.White;
            btn_Agents.Location = new Point(3, 3);
            btn_Agents.Name = "btn_Agents";
            btn_Agents.Size = new Size(486, 69);
            btn_Agents.TabIndex = 0;
            btn_Agents.Text = "Agents";
            btn_Agents.UseVisualStyleBackColor = false;
            btn_Agents.Click += btn_Agents_Click;
            // 
            // btn_Agencies
            // 
            btn_Agencies.BackColor = Color.DodgerBlue;
            btn_Agencies.Dock = DockStyle.Fill;
            btn_Agencies.FlatStyle = FlatStyle.Flat;
            btn_Agencies.Font = new Font("Arial Rounded MT Bold", 15.75F);
            btn_Agencies.ForeColor = Color.White;
            btn_Agencies.Location = new Point(495, 3);
            btn_Agencies.Name = "btn_Agencies";
            btn_Agencies.Size = new Size(486, 69);
            btn_Agencies.TabIndex = 1;
            btn_Agencies.Text = "Agencies";
            btn_Agencies.UseVisualStyleBackColor = false;
            btn_Agencies.Click += btn_Agencies_Click;
            // 
            // panel_body
            // 
            panel_body.Controls.Add(dataGridView);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(0, 150);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(984, 411);
            panel_body.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, -6);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(984, 426);
            dataGridView.TabIndex = 0;
            // 
            // AdminGUIMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel_body);
            Controls.Add(tableLayoutPanel_Bottom);
            Controls.Add(tableLayoutPanel_Top);
            Name = "AdminGUIMain";
            Text = "AdminGUIMain";
            Load += AdminGUIMain_Load;
            tableLayoutPanel_Bottom.ResumeLayout(false);
            tableLayoutPanel_Top.ResumeLayout(false);
            panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel_Bottom;
        private Button btn_Add;
        private Button btn_Modify;
        private Button btn_Delete;
        private TableLayoutPanel tableLayoutPanel_Top;
        private Button btn_Agents;
        private Button btn_Agencies;
        private Panel panel_body;
        private DataGridView dataGridView;
    }
}