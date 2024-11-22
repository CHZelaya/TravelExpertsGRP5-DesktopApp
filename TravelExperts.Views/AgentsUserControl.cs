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
            if (_agentsBindingList == null)
            {
                _agentsBindingList = new BindingList<Agent>(_agentsAndAgencies.GetActiveAgents());
                dataGridView_Base.DataSource = _agentsBindingList;
                CustomizeDataGridView();
            }
        }

        public void RefreshAgents()
        {   //Clearing the binding list (Attempting to refresh after CRUD operation)
            _agentsBindingList.Clear();
            var agents = _agentsAndAgencies.GetActiveAgents();
            foreach (var agent in agents)
            {
                {
                    _agentsBindingList.Add(agent);
                }
            }
            CustomizeDataGridView();
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
