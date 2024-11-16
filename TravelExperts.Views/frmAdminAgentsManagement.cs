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

    public partial class frmAdminAgentsManagement : Form
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;
        public frmAdminAgentsManagement()
        {
            InitializeComponent();
            ActionFlag = string.Empty; // Initialize ActionFlag to avoid CS8618 error
            var context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
        }

        //Public Variables to accept data from the AdminGUI Form

        //Action flag will be used to determine the correct course of action on this form, depending on which button is pressed on ADMINGUI. 
        public string ActionFlag { get; set; }
        public string LabelTitle { set { label_AgentsTitle.Text = value; } }

        // Passing Agent information from AdminGUI form and populating textboxes

        public string AgentID { set { textBox_AgentID.Text = value; } }
        public string AgencyID { set { textBox_AgencyID.Text = value; } }
        public string AgentFirstName { set { textBox_AgentFName.Text = value; } }

        public string AgentMiddleInitial { set { textBox_AgentMInitial.Text = value; } }

        public string AgentLastName { set { textBox_AgentLName.Text = value; } }

        public string AgentPhoneNumber { set { textBox_AgentBussPhone.Text = value; } }

        public string AgentEmail { set { textBox_AgentEmail.Text = value; } }

        public string AgentPosition { set { textBox_AgentPosition.Text = value; } }


        //ON LOAD
        /*____________________________________________________________________________________________________________________________________________________________________ */

        private void frmAdminAgentsManagement_Load(object sender, EventArgs e)
        {
            if (ActionFlag == "Addition")
            {
                label_AgentID.Text = "AgentID is Auto-Generated"; //Show AgentID warning
                textBox_AgentID.Visible = false;
                textBox_AgentID.Enabled = false;    // Disable Textbox
            }
            else if (ActionFlag == "Modify")
            {
                label_AgentID.Text = "AgentID :"; //Show AgentID warning
                textBox_AgentID.Enabled = true;
                textBox_AgentID.Visible = true;
            }
            else if (ActionFlag == "Deletion")
            {
                label_AgentID.Text = "AgentID :"; //Show AgentID warning
                textBox_AgentID.Enabled = true;
                textBox_AgentID.Visible = true;
            }
        }

        private void button_OK_Click(object? sender, EventArgs e)
        {
            if (ActionFlag == "Addition")
            {
                HandleAgentAddtion();
            }
            else if (ActionFlag == "Modify")
            {
                HandleAgentModify();
            }
            else if (ActionFlag == "Deletion")
            {
                HandleAgentModify();
            }
        }

        private void HandleAgentDeletion()
        {
            label_AgentID.Text = "AgentID :"; //Show AgentID warning
            textBox_AgentID.Enabled = true;
            textBox_AgentID.Visible = true;
            throw new NotImplementedException();
        }

        private void HandleAgentModify()
        {
            label_AgentID.Text = "AgentID :"; //Show AgentID warning
            textBox_AgentID.Enabled = true;
            textBox_AgentID.Visible = true;
            throw new NotImplementedException();
        }

        private void HandleAgentAddtion()
        {
            label_AgentID.Text = "AgentID is Auto-Generated"; //Show AgentID warning
            textBox_AgentID.Visible = false;
            textBox_AgentID.Enabled = false;    // Disable Textbox
            Agent agentToAdd = new Agent
            {
                AgtFirstName = textBox_AgentFName.Text,
                AgtMiddleInitial = textBox_AgentMInitial.Text,
                AgtLastName = textBox_AgentLName.Text,
                AgtBusPhone = textBox_AgentBussPhone.Text,
                AgtEmail = textBox_AgentEmail.Text,
                AgtPosition = textBox_AgentPosition.Text,
                AgencyId = int.TryParse(textBox_AgencyID.Text, out int agencyId) ? agencyId : (int?)null,
                AgentStatus = true

            };

            try
            {
                _agentsAndAgencies.AddAgent(agentToAdd);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Agent: {ex.Message}");


            }
        }


    }
}
