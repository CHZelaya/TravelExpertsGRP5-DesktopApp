using TravelExperts.Controllers;

namespace TravelExperts.Views
{
    public partial class AdminGUIMain : Form
    {
        private FlowLayoutPanel panel_Top;
        private Button button_Agents;
        private Button button_Agencies;
        private BaseUserControl userControl;

        private AgentsUserControl userControl_Agents;
        private AgenciesUserControl userControl_Agencies;
        private Button button_Add;
        private Button button_Modify;
        private Button button_Delete;
        private AgentsAndAgenciesControllers _agentsAndAgencies;

        public string _actionFlag { get; set; }


        public AdminGUIMain()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeUserControls();
            //subscribing to event handlers declared in BaseUserControl
            userControl = new BaseUserControl();


            this.Controls.Add(userControl);

        }

        public void InitializeLayout()
        {
            // Initialize FlowLayoutPanel
            panel_Top = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false
            };

            // Initialize Buttons
            button_Agents = new Button
            {
                Text = "Agents",
                Size = new Size(175, 40),
                Margin = new Padding(10),
                Padding = new Padding(20, 0, 20, 0)

            };
            
            button_Agencies = new Button 
            { 
                Text = "Agencies", 
                Dock = DockStyle.Top,
                Size = new Size(175, 40),
                Margin = new Padding(10),
                Padding = new Padding(20, 0, 20, 0)
            };
            button_Add = new Button
            {
                Text = "Add",
                BackColor = Color.LightGreen,
                Dock = DockStyle.Top,
                Size = new Size(175, 40),
                Margin = new Padding(10),
                Padding = new Padding(20, 0, 20, 0)
            };
            button_Modify = new Button 
            { 
                Text = "Modify", 
                BackColor = Color.LightYellow,
                Dock = DockStyle.Top,
                Size = new Size(175, 40),
                Margin = new Padding(10),
                Padding = new Padding(20, 0, 20, 0)
            };
            button_Delete = new Button 
            { 
                Text = "Delete", 
                BackColor = Color.LightCoral, 
                Dock = DockStyle.Top,
                Size = new Size(175, 40),
                Margin = new Padding(10),
                Padding = new Padding(20, 0, 20, 0)
            };



            // Adding Buttons to FlowLayoutPanel
            panel_Top.Controls.Add(button_Agents);
            panel_Top.Controls.Add(button_Agencies);
            panel_Top.Controls.Add(button_Add);
            panel_Top.Controls.Add(button_Modify);
            panel_Top.Controls.Add(button_Delete);

            // Subscribe to the Buttons
            button_Agents.Click += Button_Agents_Click;
            button_Agencies.Click += Button_Agencies_Click;
            button_Add.Click += Button_Add_Click;
            button_Modify.Click += Button_Modify_Click;
            button_Delete.Click += Button_Delete_Click;

            // Add FlowLayoutPanel to the Form
            this.Controls.Add(panel_Top);
        }



        private void InitializeUserControls()
        {
            userControl_Agents = new AgentsUserControl { Dock = DockStyle.Fill };
            userControl_Agencies = new AgenciesUserControl { Dock = DockStyle.Fill };


            this.Controls.Add(userControl_Agents);
            this.Controls.Add(userControl_Agencies);

            LoadAgentsView();
        
        }





        // VIEW LOADER AND FLAG SETTERS
        private void Button_Agents_Click(object sender, EventArgs e)
        {
            LoadAgentsView();
        }

        private void Button_Agencies_Click(object sender, EventArgs e)
        {
            LoadAgenciesView();
        }

        private void LoadAgentsView()
        {
            userControl_Agents.BringToFront();
            _actionFlag = "AgentAction";
        }

        private void LoadAgenciesView()
        {
            userControl_Agencies.BringToFront();
            _actionFlag = "AgencyAction";
        }






        //Event Handlers

        private void Button_Delete_Click(object? sender, EventArgs e)
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



        private void Button_Modify_Click(object? sender, EventArgs e)
        {
            if(_actionFlag == "AgentAction")
            {
            HandleAgentEdit();
            }
            else if(_actionFlag == "AgencyAction")
            {
                HandleAgencyEdit();
            }
        }


        private void Button_Add_Click(object? sender, EventArgs e)
        {
            if (_actionFlag == "AgentAction")
            {
                HandleAgentAddition();
            }
            else if ( _actionFlag == "AgencyAction")
            {
                HandleAgencyAddition();
            }
        }


        //AGENT ACTIONS

        private void HandleAgentAddition()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();
            var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];


            addForm.LabelTitle = "Add New Agent";
            addForm.ActionFlag = "Addition";
            // Show the form as a dialog
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                agentsUserControl.RefreshAgents(); 
            }
        }
        


   
        private void HandleAgentEdit()
        {
            try
            {
                var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agentId, firstName,  middleInitial, lastName, phoneNumber, email, position, isActive) = agentsUserControl.GetSelectedAgentRowData();

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
                    agentsUserControl.RefreshAgents(); 
                }
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandleAgentDeletion()
        {
            try
            {
                var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agentId, firstName, middleInitial, lastName, phoneNumber, email, position, isActive) = agentsUserControl.GetSelectedAgentRowData();

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
                    agentsUserControl.RefreshAgents(); // Change to instance method call
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
            var agenciesUserControl = (AgenciesUserControl)this.Controls["agenciesUserControl"];



            addForm.LabelTitle = "Add New Agency";
            addForm.ActionFlag = "Addition";
            // Show the form as a dialog
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                agenciesUserControl.RefreshAgencies();
            }
        }

        private void HandleAgencyEdit()
        {
            // Method to get selected row data
            //(int agencyId, string agencyAddress, string agencyCity, string agencyProvince, string agencyPostal, string agencyCountry, string agencyPhone, string agencyFax)
            try
            {
                var agenciesUserControl = (AgenciesUserControl)this.Controls["agenciesUserControl"];
                //var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agencyId, agencyAddress, agencyCity, agencyProvince, agencyPostal, agencyCountry, agencyPhone, agencyFax) = agenciesUserControl.GetSelectedAgencyRowData();

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
                    agenciesUserControl.RefreshAgencies();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HangleAgencyDeletion()
        {
            MessageBox.Show("Not implemeneted yet, need to add status column in db to not permenantly delete in db");
        }


    }
}