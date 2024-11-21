﻿using System.Windows.Forms;

namespace TravelExperts.Views
{
    public partial class BaseUserControl : UserControl
    {
        //Declaring controls
        private FlowLayoutPanel panel_Top;
        private TableLayoutPanel tableLayoutPanel;
        protected DataGridView dataGridView_Base;
        protected TextBox textBox_Base1;

    //Logic to set the flag for the MainForm
    // This will allow the Buttons shared between AgentControl and AgencyControl to know which CRUD operation to perform.
    public enum ActionFlag
        {
            None,
            AgentControl,
            AgencyControl
        }

        private ActionFlag currentActionFlag = ActionFlag.None;
        public ActionFlag CurrentActionFlag
        {
            get { return currentActionFlag; }
            set { currentActionFlag = value; }
        }

        public BaseUserControl()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeControls();

            this.Width = 1000;
            this.Height = 600;
        }

        private void InitializeLayout()
        {
            // Layout controls, new concept to me, need to research more.
            panel_Top = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight,
            };

            tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                AutoSize = true
            };

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

            this.Controls.Add(tableLayoutPanel);
        }

        private void InitializeControls()
        {
            Panel centerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                Anchor = AnchorStyles.None,
            };
            //Datagrid view
            dataGridView_Base = new DataGridView()
            {
                Width = 744,
                Height = 250,
                AutoSize = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false

            };
            centerPanel.Controls.Add(dataGridView_Base);
            tableLayoutPanel.Controls.Add(centerPanel, 0, 0);

            //Textboxes
            textBox_Base1 = CreateTextBox("Filter Search");
            tableLayoutPanel.Controls.Add(textBox_Base1, 0, 1);
        }




        private TextBox CreateTextBox(string placeholderText)
        {
            return new TextBox { PlaceholderText = placeholderText, Dock = DockStyle.Fill };
        }


        // Method to get selected row data
        public (int agentId, string firstName, string lastName, string middleInitial, string phoneNumber, string email, string position, bool isActive) GetSelectedRowData()
        {
            if (dataGridView_Base.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_Base.SelectedRows[0];

                // Check if the required cells are not null
                if (selectedRow.Cells["AgentId"].Value == null)
                    throw new InvalidOperationException("AgentId is null.");

                return (
                    agentId: Convert.ToInt32(selectedRow.Cells["AgentId"].Value),
                    firstName: selectedRow.Cells["AgtFirstName"].Value?.ToString() ?? string.Empty,
                    middleInitial: selectedRow.Cells["AgtMiddleInitial"].Value?.ToString() ?? string.Empty,
                    lastName: selectedRow.Cells["AgtLastName"].Value?.ToString() ?? string.Empty,
                    phoneNumber: selectedRow.Cells["AgtBusPhone"].Value?.ToString() ?? string.Empty,
                    email: selectedRow.Cells["AgtEmail"].Value?.ToString() ?? string.Empty,
                    position: selectedRow.Cells["AgtPosition"].Value?.ToString() ?? string.Empty,
                    isActive: Convert.ToBoolean(selectedRow.Cells["AgentStatus"].Value ?? false) // Default to false if null
                );
            }
            throw new InvalidOperationException("No row selected.");
        }


    }
}
