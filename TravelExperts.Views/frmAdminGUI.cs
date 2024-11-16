using TravelExperts.Controllers;
using TravelExperts.Models.Models;

namespace TravelExperts.Views
{
    public partial class frmAdminGUI : Form
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;
        public frmAdminGUI()
        {
            InitializeComponent();
            var context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
        }

        private void frmAdminGUI_Load(object sender, EventArgs e)
        {

            //Clear listbox on initial load

            LoadAgencies();
            LoadAgents();


        }

        private void LoadAgents()
        {
            var agents = _agentsAndAgencies.GetAgents();

            if (agents.Count > 0)
            {
                textBox_AgentFName.Text = agents[0].AgtFirstName;

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
            var agencies = _agentsAndAgencies.GetAgencies();

            if (agencies.Count > 0)
            {
                textBox_AgencyAddress.Text = agencies[0].AgncyAddress;
                textBox_AgencyCity.Text = agencies[0].AgncyCity;
                textBox_AgencyProvince.Text = agencies[0].AgncyProv;
                textBox_AgencyPostal.Text = agencies[0].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[0].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[0].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[0].AgncyFax;
            }

        }
    }
}
