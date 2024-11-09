namespace TravelExperts.Views
{
    using TravelExperts.Controllers;
    using TravelExperts.Models.Models;

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
            listBox_Test.Items.Clear();
            //Clear listbox on initial load

            var agents = _agentsAndAgencies.GetAgents();

            foreach (var agent in agents)
            {
                listBox_Test.Items.Add(agent.ToString());
            }


        }
    }
}
