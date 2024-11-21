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

    public partial class frmAdminGUIAgents : Form
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;
        private int _agentsCount = 0;
        public frmAdminGUIAgents()
        {
            InitializeComponent();
            var context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
            LoadAgents();
        }

        private void LoadAgents()
        {
            //Grabs Agents from DB
            var agents = _agentsAndAgencies.GetActiveAgents();


            if (agents.Count > 0)
            {
                //Populates textboxes with information from db.
                textBox_AgentFName.Text = agents[0].AgtFirstName;
                textBox_AgentID.Text = agents[0].AgentId.ToString();
                textBox_AgentLName.Text = agents[0].AgtLastName;
                textBox_AgentBussPhone.Text = agents[0].AgtBusPhone;
                textBox_AgentEmail.Text = agents[0].AgtEmail;
                textBox_AgentPosition.Text = agents[0].AgtPosition;

                if (agents[0].AgtMiddleInitial == null)
                {
                    textBox_AgentMInitial.Text = "N/A";
                }
                else
                {
                    textBox_AgentMInitial.Text = agents[0].AgtMiddleInitial;
                }

            }
        }

                    // Agent Arrow Navigation Listeners
        private void button_AgentBack_Click(object sender, EventArgs e)
        {
            HandleAgentButtonBack();
        }



        private void button_AgentForward_Click(object sender, EventArgs e)
        {
            HandleAgentButtonForward();
        }


        // Add/Modify/Delete Agent Buttons
        private void button_AgentAdd_Click(object sender, EventArgs e)
        {
            HandleAgentAddition();
        }


        private void button_AgentEdit_Click(object sender, EventArgs e)
        {
            HandleAgentEdit();
        }



        private void button_AgentDelete_Click(object sender, EventArgs e)
        {
            HandleAgentDeletion();
        }


        private void HandleAgentButtonForward()
        {


            var agents = _agentsAndAgencies.GetActiveAgents();
            var agentsCount = agents.Count;

            //Prevent button from going past the length of agents
            if (_agentsCount < agentsCount - 1)
            {
                _agentsCount += 1;
                button_AgentForward.Enabled = true;
            }
            else
            {
                button_AgentForward.Enabled = false;
            }

            // Re-enable the forward button if we are not at the end of the list
            button_AgentBack.Enabled = _agentsCount < agentsCount + 1;

            if (agents.Count > 0)
            {
                //Populates textboxes with information from db.
                textBox_AgentFName.Text = agents[_agentsCount].AgtFirstName;
                textBox_AgentID.Text = agents[_agentsCount].AgentId.ToString();
                textBox_AgentLName.Text = agents[_agentsCount].AgtLastName;
                textBox_AgentBussPhone.Text = agents[_agentsCount].AgtBusPhone;
                textBox_AgentEmail.Text = agents[_agentsCount].AgtEmail;
                textBox_AgentPosition.Text = agents[_agentsCount].AgtPosition;
                textBox_AgencyID2.Text = agents[_agentsCount].AgencyId.ToString();

                if (agents[_agentsCount].AgtMiddleInitial == null)
                {
                    textBox_AgentMInitial.Text = "N/A";
                }
                else
                {
                    textBox_AgentMInitial.Text = agents[_agentsCount].AgtMiddleInitial;
                }
            }

        }


        private void HandleAgentButtonBack()
        {


            //Grabs Agents from DB
            var agents = _agentsAndAgencies.GetActiveAgents();
            var agentsCount = agents.Count;

            if (_agentsCount > 0)
            {
                _agentsCount -= 1;
                button_AgentBack.Enabled = true;
            }// Enable back button if we can go back
            else
            {
                button_AgentBack.Enabled = false; // Disable back button if at the start
            }

            // Re-enable the forward button if we are not at the end of the list
            button_AgentForward.Enabled = _agentsCount < agentsCount - 1;

            if (agentsCount > 0)
            {
                //Populates textboxes with information from db.
                textBox_AgentFName.Text = agents[_agentsCount].AgtFirstName;
                textBox_AgentID.Text = agents[_agentsCount].AgentId.ToString();
                textBox_AgentLName.Text = agents[_agentsCount].AgtLastName;
                textBox_AgentBussPhone.Text = agents[_agentsCount].AgtBusPhone;
                textBox_AgentEmail.Text = agents[_agentsCount].AgtEmail;
                textBox_AgentPosition.Text = agents[_agentsCount].AgtPosition;
                textBox_AgencyID2.Text = agents[_agentsCount].AgencyId.ToString();

                if (agents[_agentsCount].AgtMiddleInitial == null)
                {
                    textBox_AgentMInitial.Text = "N/A";
                }
                else
                {
                    textBox_AgentMInitial.Text = agents[_agentsCount].AgtMiddleInitial;
                }

            } 
        }

                    /// <summary>
                    /// Handle Agent Addition
                    /// </summary>
        private static void HandleAgentAddition()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

            addForm.LabelTitle = "Add New Agent";
            addForm.ActionFlag = "Addition";
            addForm.ShowDialog();
        }

        /// <summary>
        /// Handle clicking Agent Edit button - Populate texboxes in second form with values of corresponding textboxes in AdminGUI form.
        /// </summary>
        private void HandleAgentEdit()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

            addForm.ActionFlag = "Modify";
            addForm.LabelTitle = "Modify Existing Agent";
            addForm.AgentID = textBox_AgentID.Text;
            addForm.AgencyID = textBox_AgencyID2.Text;
            addForm.AgentFirstName = textBox_AgentFName.Text;
            addForm.AgentLastName = textBox_AgentLName.Text;
            addForm.AgentMiddleInitial = textBox_AgentMInitial.Text;
            addForm.AgentPhoneNumber = textBox_AgentBussPhone.Text;
            addForm.AgentEmail = textBox_AgentEmail.Text;
            addForm.AgentPosition = textBox_AgentPosition.Text;

            addForm.ShowDialog();
        }

        private static void HandleAgentDeletion()
        {
            frmAdminAgentsManagement addForm = new frmAdminAgentsManagement();

            addForm.LabelTitle = "Delete Existing Agent";
            addForm.ActionFlag = "Deletion";
            addForm.ShowDialog();
        }

    }



}
