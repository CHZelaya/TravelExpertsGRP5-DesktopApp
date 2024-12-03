using System.Data;
using TravelExperts.Controllers;
using TravelExperts.Models.Models;

namespace TravelExperts.Views
{
    public partial class AdminGUIMain : Form
    {

        private TravelExpertsContext _context;
        private AgentsAndAgenciesControllers _agentsAndAgencies;

        public string _actionFlag { get; set; }


        public AdminGUIMain()
        {

            InitializeComponent();

            //Initialize the context and controller
            _context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(_context);
 
  
           


        }

        //ON LOAD   
        private void AdminGUIMain_Load(object sender, EventArgs e)
        {
            _actionFlag = "AgentAction";
            LoadAgentsView();
            CustomizeDataGridViewAgents();
            EnableSorting();
        }


        // AGENT/AGENCIES EVENT LISTENERS, VIEW LOADER AND FLAG SETTERS


        private void btn_Agents_Click(object sender, EventArgs e)
        {
            LoadAgentsView();
        }

        private void btn_Agencies_Click(object sender, EventArgs e)
        {
            LoadAgenciesView();
        }


        private void LoadAgentsView()
        {
            var agentsList = _agentsAndAgencies.GetActiveAgents();
            _actionFlag = "AgentAction";
            dataGridView.DataSource = agentsList;
            CustomizeDataGridViewAgents();
        }

        private void LoadAgenciesView()
        {
            var agenciesList = _agentsAndAgencies.GetActiveAgencies();
            _actionFlag = "AgencyAction";
            dataGridView.DataSource = agenciesList;
            CustomizeDataGridViewAgencies();

        }




        //AGENT/AGENCY ACTION EVENT LISTENERS

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (_actionFlag == "AgentAction")
            {
                HandleAgentAddition();
            }
            else if (_actionFlag == "AgencyAction")
            {
                HandleAgencyAddition();
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (_actionFlag == "AgentAction")
            {
                HandleAgentEdit();
            }
            else if (_actionFlag == "AgencyAction")
            {
                HandleAgencyEdit();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (_actionFlag == "AgentAction")
            {
                HandleAgentDeletion();
            }
            else if (_actionFlag == "AgencyAction")
            {
                HangleAgencyDeletion();
            }
        }




        //AGENT ACTIONS

        private void HandleAgentAddition()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();
            //var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];


            addForm.LabelTitle = "Add New Agent";
            addForm.ActionFlag = "Addition";
            // Show the form as a dialog
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _agentsAndAgencies.GetActiveAgents();
            }
        }




        private void HandleAgentEdit()
        {
            try
            {
                var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agentId, firstName, middleInitial, lastName, phoneNumber, email, position, isActive) = GetSelectedAgentRowData();

                frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

                addForm.LabelTitle = "Modify Existing Agent";
                addForm.ActionFlag = "Modify";
                addForm.AgentID = agentId;
                addForm.AgentFirstName = firstName;
                addForm.AgentMiddleInitial = middleInitial;
                addForm.AgentLastName = lastName;
                addForm.AgentPhoneNumber = phoneNumber;
                addForm.AgentEmail = email;
                addForm.AgentPosition = position;

                // Show the form as a dialog
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _agentsAndAgencies.GetActiveAgents();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandleAgentDeletion()
        {
            try
            {
                //var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agentId, firstName, middleInitial, lastName, phoneNumber, email, position, isActive) = GetSelectedAgentRowData();

                frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

                // Populate textboxes
                addForm.ActionFlag = "Deletion";
                addForm.LabelTitle = "Delete Existing Agent";
                addForm.AgentID = agentId;
                addForm.AgentFirstName = firstName;
                addForm.AgentMiddleInitial = middleInitial;
                addForm.AgentLastName = lastName;
                addForm.AgentPhoneNumber = phoneNumber;
                addForm.AgentEmail = email;
                addForm.AgentPosition = position;



                // Show the form as a dialog
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _agentsAndAgencies.GetActiveAgents(); // Change to instance method call
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // AGENCY ACTIONS

        private void HandleAgencyAddition()
        {
            frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();
            //var agenciesUserControl = (AgenciesUserControl)this.Controls["agenciesUserControl"];



            addForm.LabelTitle = "Add New Agency";
            addForm.ActionFlag = "Addition";
            // Show the form as a dialog
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _agentsAndAgencies.GetActiveAgencies();
            }
        }

        private void HandleAgencyEdit()
        {
            // Method to get selected row data
            //(int agencyId, string agencyAddress, string agencyCity, string agencyProvince, string agencyPostal, string agencyCountry, string agencyPhone, string agencyFax)
            try
            {
                //var agenciesUserControl = (AgenciesUserControl)this.Controls["agenciesUserControl"];
                //var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agencyId, agencyAddress, agencyCity, agencyProvince, agencyPostal, agencyCountry, agencyPhone, agencyFax) = GetSelectedAgencyRowData();

                frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();

                addForm.LabelTitle = "Modify Existing Agency";
                addForm.ActionFlag = "Modify";
                addForm.AgencyID = agencyId;
                addForm.AgencyAddress = agencyAddress;
                addForm.AgencyCity = agencyCity;
                addForm.AgencyProvince = agencyProvince;
                addForm.AgencyPostalCode = agencyPostal;
                addForm.AgencyCountry = agencyCountry;
                addForm.AgencyFax = agencyFax;

                // Show the form as a dialog
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _agentsAndAgencies.GetActiveAgencies();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HangleAgencyDeletion()
        {
            try
            {

                var (agencyId, agencyAddress, agencyCity, agencyProvince, agencyPostal, agencyCountry, agencyPhone, agencyFax) = GetSelectedAgencyRowData();

                frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();

                addForm.LabelTitle = "Delete Existing Agency";
                addForm.ActionFlag = "Deletion";
                addForm.AgencyID = agencyId;
                addForm.AgencyAddress = agencyAddress;
                addForm.AgencyCity = agencyCity;
                addForm.AgencyProvince = agencyProvince;
                addForm.AgencyPostalCode = agencyPostal;
                addForm.AgencyCountry = agencyCountry;
                addForm.AgencyFax = agencyFax;

                // Show the form as a dialog
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _agentsAndAgencies.GetActiveAgencies();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // HELPER FUNCTIONS

        private void EnableSorting()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        /// <summary>
        /// Change Grid headers more user friendly
        /// </summary>
        private void CustomizeDataGridViewAgents()
        {   //Hiding specific columns
            if (dataGridView.Columns.Contains("AgentID"))
            {
                dataGridView.Columns["AgentID"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Agency"))
            {
                dataGridView.Columns["Agency"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Customers"))
            {
                dataGridView.Columns["Customers"].Visible = false;
            }
            if (dataGridView.Columns.Contains("AgencyID"))
            {
                dataGridView.Columns["AgencyID"].Visible = false;
            }
            //Renaming Columns
            dataGridView.Columns["AgtFirstName"].HeaderText = "First Name";
            dataGridView.Columns["AgtMiddleInitial"].HeaderText = "Middle Name";
            dataGridView.Columns["AgtLastName"].HeaderText = "Last Name";
            dataGridView.Columns["AgtBusPhone"].HeaderText = "Phone Number";
            dataGridView.Columns["AgtEmail"].HeaderText = "Email";
            dataGridView.Columns["AgtPosition"].HeaderText = "Position";
            dataGridView.Columns["AgentStatus"].HeaderText = "Status";
            dataGridView.Columns["AgentStatus"].ReadOnly = true;

        }

        private void CustomizeDataGridViewAgencies()
        {   //Hiding specific columns
            if (dataGridView.Columns.Contains("Agents"))
            {
                dataGridView.Columns["Agents"].Visible = false;
            }
            if (dataGridView.Columns.Contains("AgencyID"))
            {
                dataGridView.Columns["AgencyID"].Visible = false;
            }
            if (dataGridView.Columns.Contains("AgencyID"))
            {
                dataGridView.Columns["AgencyID"].Visible = false;
            }
            //Changing Column names to user friendly versions

            dataGridView.Columns["AgncyAddress"].HeaderText = "Address";
            dataGridView.Columns["AgncyCity"].HeaderText = "City";
            dataGridView.Columns["AgncyProv"].HeaderText = "Province";
            dataGridView.Columns["AgncyPostal"].HeaderText = "Postal Code";
            dataGridView.Columns["AgncyCountry"].HeaderText = "Country";
            dataGridView.Columns["AgncyAddress"].HeaderText = "Address";
            dataGridView.Columns["AgncyPhone"].HeaderText = "Phone";
            dataGridView.Columns["AgncyFax"].HeaderText = "Fax";
            dataGridView.Columns["AgencyStatus"].HeaderText = "Status";


        }

        // GRAB SELECTED AGENT ROW INFORMATION
        public (int agentId, string firstName, string lastName, string middleInitial, string phoneNumber, string email, string position, bool isActive) GetSelectedAgentRowData()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];

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


        //GET SELECTED AGENCY ROW INFORMATION
        public (int agencyId, string agencyAddress, string agencyCity, string agencyProvince, string agencyPostal, string agencyCountry, string agencyPhone, string agencyFax) GetSelectedAgencyRowData()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];

                // Check if the required cells are not null
                if (selectedRow.Cells["AgencyId"].Value == null)
                    throw new InvalidOperationException("AgencyId is null.");

                return (
                    agencyId: Convert.ToInt32(selectedRow.Cells["AgencyId"].Value),
                    agencyAddress: selectedRow.Cells["AgncyAddress"].Value?.ToString() ?? string.Empty,
                    agencyCity: selectedRow.Cells["AgncyCity"].Value?.ToString() ?? string.Empty,
                    agencyProvince: selectedRow.Cells["AgncyProv"].Value?.ToString() ?? string.Empty,
                    agencyPostal: selectedRow.Cells["AgncyPostal"].Value?.ToString() ?? string.Empty,
                    agencyCountry: selectedRow.Cells["AgncyCountry"].Value?.ToString() ?? string.Empty,
                    agencyPhone: selectedRow.Cells["AgncyPhone"].Value?.ToString() ?? string.Empty,
                    agencyFax: selectedRow.Cells["AgncyFax"].Value?.ToString() ?? string.Empty
                );
            }
            throw new InvalidOperationException("No row selected.");
        }


    }//Class


}//Namespace


//Revamping Design, tossed out code


//private TableLayoutPanel panel_Top;
//private TableLayoutPanel panel_Bottom;
//private Button button_Agents;
//private Button button_Agencies;
//private BaseUserControl userControl;

//private AgentsUserControl userControl_Agents;
//private AgenciesUserControl userControl_Agencies;
//private Button button_Add;
//private Button button_Modify;
//private Button button_Delete;


//public void InitializeLayout()
//{
//    // Initialize FlowLayoutPanel
//    panel_Top = new TableLayoutPanel
//    {
//        Dock = DockStyle.Top,
//        Height = 50,
//        ColumnCount = 2,
//        RowCount = 1,
//        AutoSize = true
//    };

//    // Set each column to take up 50% of the width
//    panel_Top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // First column
//    panel_Top.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // Second column

//    // Initialize Buttons
//    button_Agents = new Button
//    {
//        Text = "Agents",
//        Dock = DockStyle.Fill

//    };

//    button_Agencies = new Button 
//    { 
//        Text = "Agencies", 
//        Dock = DockStyle.Fill,

//    };

//    // Add buttons to the first TableLayoutPanel
//    panel_Top.Controls.Add(button_Agents, 0, 0); // Column 0
//    panel_Top.Controls.Add(button_Agencies, 1, 0); // Column 1


//    panel_Bottom = new TableLayoutPanel
//    {
//        Dock = DockStyle.Bottom,
//        Height = 50,
//        ColumnCount = 3,
//        RowCount = 1,
//        AutoSize = true

//    };

//    // Set each column to take up 33.33% of the width
//    panel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // First column
//    panel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Second column
//    panel_Bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Third column

//    button_Add = new Button
//    {
//        Text = "Add",
//        BackColor = Color.LightGreen,
//        Dock = DockStyle.Fill,
//        Size = new Size(175, 40),
//        Margin = new Padding(10),
//        Padding = new Padding(20, 0, 20, 0)
//    };


//    button_Modify = new Button 
//    { 
//        Text = "Modify", 
//        BackColor = Color.LightYellow,
//        Dock = DockStyle.Fill,
//        Size = new Size(175, 40),
//        Margin = new Padding(10),
//        Padding = new Padding(20, 0, 20, 0)
//    };
//    button_Delete = new Button 
//    { 
//        Text = "Delete", 
//        BackColor = Color.LightCoral, 
//        Dock = DockStyle.Fill,
//        Size = new Size(175, 40),
//        Margin = new Padding(10),
//        Padding = new Padding(20, 0, 20, 0)
//    };



//    // Adding Buttons to FlowLayoutPanel
//    panel_Bottom.Controls.Add(button_Add, 0, 0);
//    panel_Bottom.Controls.Add(button_Modify, 1,0);
//    panel_Bottom.Controls.Add(button_Delete, 2, 0);

//    // Subscribe to the Buttons
//    button_Agents.Click += Button_Agents_Click;
//    button_Agencies.Click += Button_Agencies_Click;
//    button_Add.Click += Button_Add_Click;
//    button_Modify.Click += Button_Modify_Click;
//    button_Delete.Click += Button_Delete_Click;

//    // Add FlowLayoutPanel to the Form
//    this.Controls.Add(panel_Top);
//}


//private void Button_Delete_Click(object? sender, EventArgs e)
//{

//}



//private void Button_Modify_Click(object? sender, EventArgs e)
//{

//}


//private void Button_Add_Click(object? sender, EventArgs e)
//{

//}



//private void InitializeUserControls()
//{
//    userControl_Agents = new AgentsUserControl { Dock = DockStyle.Fill };
//    userControl_Agencies = new AgenciesUserControl { Dock = DockStyle.Fill };


//    this.Controls.Add(userControl_Agents);
//    this.Controls.Add(userControl_Agencies);

//    LoadAgentsView();

//}


//InitializeLayout();
//InitializeUserControls();
//subscribing to event handlers declared in BaseUserControl
//userControl = new BaseUserControl();


//this.Controls.Add(userControl);

//private void Button_Agents_Click(object sender, EventArgs e)
//{

//}

//private void Button_Agencies_Click(object sender, EventArgs e)
//{

//}