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




        //Event Handlers

        private void Button_Delete_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked!");
        }

        private void Button_Modify_Click(object? sender, EventArgs e)
        {
            HandleAgentEdit();
        }

        private void Button_Add_Click(object? sender, EventArgs e)
        {
            HandleAgentAddition();
        }


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
            userControl_Agents.CurrentActionFlag = BaseUserControl.ActionFlag.AgentControl;
        }

        private void LoadAgenciesView()
        {
            userControl_Agencies.BringToFront();
            userControl_Agencies.CurrentActionFlag = BaseUserControl.ActionFlag.AgencyControl;
        }

        private void HandleAgentAddition()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();
            var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

            addForm.LabelTitle = "Add New Agent";
            addForm.ActionFlag = "Addition";
            // Show the form as a dialog
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                agentsUserControl.RefreshAgents(); // Change to instance method call
            }
        }
        

        private void HandleAgentEdit()
        {
            try
            {
                var agentsUserControl = (AgentsUserControl)this.Controls["agentsUserControl"];

                var (agentId, firstName,  middleInitial, lastName, phoneNumber, email, position, isActive) = agentsUserControl.GetSelectedRowData();

                frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

                addForm.LabelTitle = "Modify Existing Agent";
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
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}