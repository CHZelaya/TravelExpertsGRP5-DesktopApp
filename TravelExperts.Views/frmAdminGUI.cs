using TravelExperts.Controllers;
using TravelExperts.Models.Models;

namespace TravelExperts.Views
{
    public partial class frmAdminGUI : Form
    {


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
            //Load Agency and Agent data on load.
            LoadAgencies();


        }

        // ON LOAD METHODS
        /*____________________________________________________________________________________________________________________________________________________________________ */



        private void LoadAgencies()
        {
            //Grabs Agencies from DB
            var agencies = _agentsAndAgencies.GetAgencies();

            if (agencies.Count > 0)
            {
                // Populates textboxes with information from db.
                textBox_AgencyAddress.Text = agencies[0].AgncyAddress;
                textBox_AgencyID1.Text = agencies[0].AgencyId.ToString();
                textBox_AgencyCity.Text = agencies[0].AgncyCity;
                textBox_AgencyProvince.Text = agencies[0].AgncyProv;
                textBox_AgencyPostal.Text = agencies[0].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[0].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[0].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[0].AgncyFax;
            }

        }




        // EVENT LISTENERS
        /*____________________________________________________________________________________________________________________________________________________________________ */

        //Agency Arrow Navigation listeners
        private void button_AgenciesForward_Click(object sender, EventArgs e)
        {
            HandleAgenciesButtonForward();
        }


        private void button_AgenciesBack_Click(object sender, EventArgs e)
        {
            HandleAgenciesButtonBack();
        }





        // Add/Modify/Delete Agency Buttons

        private void button_AgencyAdd_Click(object sender, EventArgs e)
        {
            HandleAgencyAddition();
        }


        private void button_AgencyEdit_Click(object sender, EventArgs e)
        {
            HandleAgencyEdit();
        }

        private void button_AgencyDelete_Click(object sender, EventArgs e)
        {
            HandleAgencyDeletion();
        }











        // BUTTON LOGIC 
        /*____________________________________________________________________________________________________________________________________________________________________ */

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
                textBox_AgencyCity.Text = agencies[_agenciesCount].AgncyCity;
                textBox_AgencyProvince.Text = agencies[_agenciesCount].AgncyProv;
                textBox_AgencyPostal.Text = agencies[_agenciesCount].AgncyPostal;
                textBox_AgencyCountry.Text = agencies[_agenciesCount].AgncyCountry;
                textBox_AgencyBusPhone.Text = agencies[_agenciesCount].AgncyPhone;
                textBox_AgencyFaxPhone.Text = agencies[_agenciesCount].AgncyFax;
            }
        }






        /// <summary>
        /// Handle Agency Addition
        /// </summary>
        private static void HandleAgencyAddition()
        {
            frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();

            addForm.LabelTitle = "Add New Agency";
            addForm.ActionFlag = "Addition";
            addForm.ShowDialog();
        }

        /// <summary>
        /// Handle Agency Edit - Populate texboxes in second form with values of corresponding textboxes in AdminGUI form.
        /// </summary>
        private void HandleAgencyEdit()
        {
            frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();

            addForm.ActionFlag = "Modify";
            addForm.LabelTitle = "Modify Existing Agency";
            addForm.AgencyID = textBox_AgencyID1.Text;
            addForm.AgencyAddress = textBox_AgencyAddress.Text;
            addForm.AgencyCity = textBox_AgencyCity.Text;
            addForm.AgencyProvince = textBox_AgencyProvince.Text;
            addForm.AgencyPostalCode = textBox_AgencyPostal.Text;
            addForm.AgencyCountry = textBox_AgencyCountry.Text;
            addForm.AgencyBusPhone = textBox_AgencyBusPhone.Text;
            addForm.AgencyFax = textBox_AgencyFaxPhone.Text;

            addForm.ShowDialog();

        }

        private void HandleAgencyDeletion()
        {
            frmAdminAgenciesManagement addForm = new frmAdminAgenciesManagement();

            addForm = new frmAdminAgenciesManagement();
            addForm.LabelTitle = "Delete Existing Agency";
            addForm.ActionFlag = "Deletion";

            addForm.ShowDialog();
        }





    }

}

