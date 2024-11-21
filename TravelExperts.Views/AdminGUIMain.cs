using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public AdminGUIMain()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeUserControls();
            //subscribing to event handlers declared in BaseUserControl
            userControl = new BaseUserControl();
            userControl.AddButtonClicked += UserControl_AddButtonClicked;
            userControl.ModifyButtonClicked += UserControl_ModifyButtonClicked;
            userControl.DeleteButtonClicked += UserControl_DeleteButtonClicked;

            this.Controls.Add(userControl);

        }

        public void InitializeLayout()
        {
            // Initialize FlowLayoutPanel
            panel_Top = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight
            };

            // Initialize Buttons
            button_Agents = new Button { Text = "Agents", Dock = DockStyle.Top };
            button_Agencies = new Button { Text = "Agencies", Dock = DockStyle.Top };

            // Adding Buttons to FlowLayoutPanel
            panel_Top.Controls.Add(button_Agents);
            panel_Top.Controls.Add(button_Agencies);

            // Subscribe to the Buttons
            button_Agents.Click += Button_Agents_Click;
            button_Agencies.Click += Button_Agencies_Click;

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

        private void UserControl_DeleteButtonClicked(object? sender, EventArgs e)
        {
            // Logic for deleting an item
            MessageBox.Show("Delete button clicked in UserControl!");
        }

        private void UserControl_ModifyButtonClicked(object? sender, EventArgs e)
        {
            // Logic for modifying an item
            MessageBox.Show("Modify button clicked in UserControl!");
        }

        private void UserControl_AddButtonClicked(object? sender, EventArgs e)
        {
            // Logic for adding an item
            MessageBox.Show("Add button clicked in UserControl!");
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



    }
}