using TravelExperts.Controllers;
using TravelExperts.Models.Models;

namespace TravelExperts.Views
{
    public partial class frmAdminGUI : Form
    {

        private int _agentsCount = 0;
        private int _agenciesCount = 0;


        private AgentsAndAgenciesControllers _agentsAndAgencies;
        public frmAdminGUI()
        {
            InitializeComponent();
            var context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
        }

        private void FrmAdminGUI_Load(object sender, EventArgs e)
        {

            //Clear listbox on initial load

            LoadAgencies();
            LoadAgents();




        }

        // ON LOAD METHODS
        private void LoadAgents()
        {
            //Grabs Agents from DB
            var agents = _agentsAndAgencies.GetAgents();

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

        private void LoadAgencies()
        {
            //Grabs Agencies from DB
            var agencies = _agentsAndAgencies.GetAgencies();

            if (agencies.Count > 0)
            {
                // Populates textboxes with information from db.
                textBox_AgencyAddress.Text = agencies[0].AgncyAddress;
                textBox_AgencyID1.Text = agencies[0].AgencyId.ToString();
                textBox_AgencyID2.Text = agencies[0].AgencyId.ToString();
                textBox_AgencyCity.Text = agencies[0].AgncyCity;
                textBox_AgencyProvince.Text = agencies[0].AgncyProv;
                textBox_AgencyPostal.Text = agencies[0].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[0].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[0].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[0].AgncyFax;
            }

        }


        // EVENT LISTENERS


        //Agency Arrow Navigation listeners
        private void button_AgenciesForward_Click(object sender, EventArgs e)
        {
            HandleAgenciesButtonForward();
        }


        private void button_AgenciesBack_Click(object sender, EventArgs e)
        {
            HandleAgenciesButtonBack();
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






        // BUTTON LOGIC 

        //Logic involving the Navigation Arrows in the Agencies and Agents section.
        private void HandleAgenciesButtonForward()
        {
            var agencies = _agentsAndAgencies.GetAgencies();
            var agenciesCount = agencies.Count;

            // Increment the agency count only if it is less than the total number of agencies - 1
            if (_agenciesCount < agenciesCount - 1)
            {
                _agenciesCount += 1;
            }

            // Enable back button if we are not at the start
            button_AgenciesBack.Enabled = _agenciesCount > 0;

            // Re-enable the forward button if we are not at the end of the list
            button_AgenciesForward.Enabled = _agenciesCount < agenciesCount - 1;

            if (agenciesCount > 0)
            {
                // Populate textboxes with information from the database.
                textBox_AgencyID1.Text = agencies[_agenciesCount].AgencyId.ToString();
                textBox_AgencyID2.Text = agencies[_agenciesCount].AgencyId.ToString();
                textBox_AgencyCity.Text = agencies[_agenciesCount].AgncyCity;
                textBox_AgencyProvince.Text = agencies[_agenciesCount].AgncyProv;
                textBox_AgencyPostal.Text = agencies[_agenciesCount].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[_agenciesCount].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[_agenciesCount].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[_agenciesCount].AgncyFax;
            }
        }



        private void HandleAgenciesButtonBack()
        {
            var agencies = _agentsAndAgencies.GetAgencies();
            var agenciesCount = agencies.Count;

            // Decrement the agency count only if it is greater than zero
            if (_agenciesCount > 0)
            {
                _agenciesCount -= 1;
            }

            // Enable back button if we are not at the start
            button_AgenciesBack.Enabled = _agenciesCount > 0;

            // Re-enable the forward button if we are not at the end of the list
            button_AgenciesForward.Enabled = _agenciesCount < agenciesCount - 1;

            if (agenciesCount > 0)
            {
                // Populate textboxes with information from the database.
                textBox_AgencyAddress.Text = agencies[_agenciesCount].AgncyAddress;
                textBox_AgencyID1.Text = agencies[_agenciesCount].AgencyId.ToString();
                textBox_AgencyID2.Text = agencies[_agenciesCount].AgencyId.ToString();
                textBox_AgencyCity.Text = agencies[_agenciesCount].AgncyCity;
                textBox_AgencyProvince.Text = agencies[_agenciesCount].AgncyProv;
                textBox_AgencyPostal.Text = agencies[_agenciesCount].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[_agenciesCount].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[_agenciesCount].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[_agenciesCount].AgncyFax;
            }
        }



        private void HandleAgentButtonForward()
        {


            var agents = _agentsAndAgencies.GetAgents();
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
            button_AgentBack.Enabled = _agentsCount < agentsCount +1 ;

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
            var agents = _agentsAndAgencies.GetAgents();
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
    }

}

