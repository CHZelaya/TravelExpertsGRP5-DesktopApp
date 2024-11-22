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
    public partial class AgenciesUserControl : BaseUserControl
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;
        private TravelExpertsContext _context; // Add this field to hold the context

        public AgenciesUserControl()
        {
            InitializeComponent();
            this.Size = new Size(985, 495);
            _context = new TravelExpertsContext(); // Initialize the context
            _agentsAndAgencies = new AgentsAndAgenciesControllers(_context); // Pass the context to the controller
            LoadAgencies();

        }


        private void LoadAgencies()
        {
            if (_agentsAndAgencies != null)
            {
                var agencies = _agentsAndAgencies.GetAgencies();
                dataGridView_Base.DataSource = agencies;
                CustomizeDataGridView();
            }
            else
            {
                // Handle the null case, maybe log an error or show a message to the user
            }
        }

        public void RefreshAgencies()
        {
            LoadAgencies();
        }

        private void CustomizeDataGridView()
        {   //Hiding specific columns
            if (dataGridView_Base.Columns.Contains("Agents"))
            {
                dataGridView_Base.Columns["Agents"].Visible = false;
            }
            if (dataGridView_Base.Columns.Contains("AgencyID"))
            {
                dataGridView_Base.Columns["AgencyID"].Visible = false;
            }
            if (dataGridView_Base.Columns.Contains("AgencyID"))
            {
                dataGridView_Base.Columns["AgencyID"].Visible = false;
            }
            //Changing Column names to user friendly versions

            dataGridView_Base.Columns["AgncyAddress"].HeaderText = "Address";
            dataGridView_Base.Columns["AgncyCity"].HeaderText = "City";
            dataGridView_Base.Columns["AgncyProv"].HeaderText = "Province";
            dataGridView_Base.Columns["AgncyPostal"].HeaderText = "Postal Code";
            dataGridView_Base.Columns["AgncyCountry"].HeaderText = "Country";
            dataGridView_Base.Columns["AgncyAddress"].HeaderText = "Address";
            dataGridView_Base.Columns["AgncyPhone"].HeaderText = "Phone";
            dataGridView_Base.Columns["AgncyFax"].HeaderText = "Fax";




        }
    }
}


