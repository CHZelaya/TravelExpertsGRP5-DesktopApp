using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Controllers;
using TravelExperts.Models.Models;

namespace TravelExperts.Views
{
    public partial class AgentsUserControl : BaseUserControl
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;
        private BindingList<Agent> _agentsBindingList;

        public AgentsUserControl()
        {
            InitializeComponent();
            this.Size = new Size(985, 495);
            var context = new TravelExpertsContext(); // Assuming TravelExpertsContext is available and properly configured
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
            LoadAgents();
        }

        private void LoadAgents()
        {
            var agents = new BindingList<Agent>(_agentsAndAgencies.GetActiveAgents());
            dataGridView_Base.DataSource = agents;
            _agentsBindingList = agents; // Store the binding list for later use
            CustomizeDataGridView();
        }

        public void RefreshAgents()
        {
            LoadAgents();
        }

        //EventListeners for buttons


        private void CustomizeDataGridView()
        {   //Hiding specific columns
            if (dataGridView_Base.Columns.Contains("AgentID"))
            {
                dataGridView_Base.Columns["AgentID"].Visible = false;
            }
            if (dataGridView_Base.Columns.Contains("Agency"))
            {
                dataGridView_Base.Columns["Agency"].Visible = false;
            }
            if (dataGridView_Base.Columns.Contains("Customers"))
            {
                dataGridView_Base.Columns["Customers"].Visible = false;
            }
            if (dataGridView_Base.Columns.Contains("AgencyID"))
            {
                dataGridView_Base.Columns["AgencyID"].Visible=false;
            }
            //Renaming Columns
            dataGridView_Base.Columns["AgtFirstName"].HeaderText = "First Name";
            dataGridView_Base.Columns["AgtMiddleInitial"].HeaderText = "Middle Name";
            dataGridView_Base.Columns["AgtLastName"].HeaderText = "Last Name";
            dataGridView_Base.Columns["AgtBusPhone"].HeaderText = "Phone Number";
            dataGridView_Base.Columns["AgtEmail"].HeaderText = "Email";
            dataGridView_Base.Columns["AgtPosition"].HeaderText = "Position";
            dataGridView_Base.Columns["AgentStatus"].HeaderText = "Status";
            dataGridView_Base.Columns["AgentStatus"].ReadOnly = true;
        }
    }

}
