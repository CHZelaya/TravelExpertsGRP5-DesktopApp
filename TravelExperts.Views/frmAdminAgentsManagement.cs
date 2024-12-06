using Microsoft.EntityFrameworkCore;
using TravelExperts.Controllers;
using TravelExperts.Models.Models;
using TravelExperts.Views.Utils;

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
        public int AgentID { get; set; }
        public string AgentFirstName { set { textBox_AgentFName.Text = value; } }

        public string AgentMiddleInitial { set { textBox_AgentMInitial.Text = value; } }

        public string AgentLastName { set { textBox_AgentLName.Text = value; } }

        public string AgentPhoneNumber { set { textBox_AgentBussPhone.Text = value; } }

        public string AgentEmail { set { textBox_AgentEmail.Text = value; } }

        public string AgentPosition { set { comboBox_AgtPosition.Text = value; } }

        //public bool AgentStatus { set { text} }


        //ON LOAD
        /*____________________________________________________________________________________________________________________________________________________________________ */

        private void frmAdminAgentsManagement_Load(object sender, EventArgs e)
        {
            if (ActionFlag == "Deletion")
            {
                //Setting textboxes to read only
                textBox_AgentFName.Enabled = false;
                textBox_AgentLName.Enabled = false;
                textBox_AgentMInitial.Enabled = false;
                textBox_AgentBussPhone.Enabled = false;
                textBox_AgentEmail.Enabled = false;
                comboBox_AgtPosition.Enabled = false;
            }
            else
            {
                textBox_AgentFName.Enabled = true;
                textBox_AgentLName.Enabled = true;
                textBox_AgentMInitial.Enabled = true;
                textBox_AgentBussPhone.Enabled = true;
                textBox_AgentEmail.Enabled = true;
                comboBox_AgtPosition.Enabled = true;
            }
        }


        private void button_OK_Click(object? sender, EventArgs e)
        {

            if (
                (ActionFlag == "Addition" || ActionFlag == "Modify") && // Check for Addition or Modify
                                                                        // Check First Name
                GenericValidations.IsPresent(textBox_AgentFName) &&
                GenericValidations.IsAlphanumericWithHyphens(textBox_AgentFName) &&
                // Check Middle Initial
                GenericValidations.IsPresent(textBox_AgentMInitial) &&
                GenericValidations.IsAlphanumericWithHyphens(textBox_AgentMInitial) &&
                // Check Last Name
                GenericValidations.IsPresent(textBox_AgentLName) &&
                GenericValidations.IsAlphanumericWithHyphens(textBox_AgentLName) &&
                // Check Phone Number
                GenericValidations.IsPresent(textBox_AgentBussPhone) &&
                GenericValidations.IsValidPhoneNumber(textBox_AgentBussPhone) &&
                // Check Email
                GenericValidations.IsPresent(textBox_AgentEmail) &&
                GenericValidations.IsValidEmail(textBox_AgentEmail)
            )
            {
                if (ActionFlag == "Addition")
                {
                    HandleAgentAddtion();
                }
                else if (ActionFlag == "Modify")
                {
                    HandleAgentModify();
                }
            }
            else if (ActionFlag == "Deletion")
            {
                HandleAgentDeletion();
            }
        }

        private void HandleAgentDeletion()
        {


            Agent agentToDelete = new Agent
            {
                AgentId = AgentID,
                //AgtFirstName = textBox_AgentFName.Text,
                //AgtMiddleInitial = textBox_AgentMInitial.Text,
                //AgtLastName = textBox_AgentLName.Text,
                //AgtBusPhone = textBox_AgentBussPhone.Text,
                //AgtEmail = textBox_AgentEmail.Text,
                //AgtPosition = textBox_AgentPosition.Text,
                AgentStatus = false

            };
            try
            {
                _agentsAndAgencies.DeleteAgent(agentToDelete);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while deleting agent: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Agent: {ex.Message}");
            }
        }

        private void HandleAgentModify()
        {

            Agent agentToUpdate = new Agent
            {
                AgentId = AgentID,
                AgtFirstName = textBox_AgentFName.Text,
                AgtMiddleInitial = textBox_AgentMInitial.Text,
                AgtLastName = textBox_AgentLName.Text,
                AgtBusPhone = textBox_AgentBussPhone.Text,
                AgtEmail = textBox_AgentEmail.Text,
                AgtPosition = comboBox_AgtPosition.Text,
                AgentStatus = true

            };

            try
            {
                _agentsAndAgencies.UpdateAgent(agentToUpdate);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while modifying agent: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Modifying Agent: {ex.Message}");
            }

        }

        private void HandleAgentAddtion()
        {

            Agent agentToAdd = new Agent
            {
                AgtFirstName = textBox_AgentFName.Text,
                AgtMiddleInitial = textBox_AgentMInitial.Text,
                AgtLastName = textBox_AgentLName.Text,
                AgtBusPhone = textBox_AgentBussPhone.Text,
                AgtEmail = textBox_AgentEmail.Text,
                AgtPosition = comboBox_AgtPosition.Text,
                AgentStatus = true

            };

            try
            {
                _agentsAndAgencies.AddAgent(agentToAdd);
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while adding agent: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Agent: {ex.Message}");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
