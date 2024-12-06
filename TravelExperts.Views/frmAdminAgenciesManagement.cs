using Microsoft.EntityFrameworkCore;
using TravelExperts.Controllers;
using TravelExperts.Models.Models;
using TravelExperts.Views.Utils;

namespace TravelExperts.Views
{
    public partial class frmAdminAgenciesManagement : Form
    {
        private AgentsAndAgenciesControllers _agentsAndAgencies;

        public frmAdminAgenciesManagement()
        {
            InitializeComponent();
            ActionFlag = string.Empty; // Initialize ActionFlag to avoid CS8618 error
            var context = new TravelExpertsContext();
            _agentsAndAgencies = new AgentsAndAgenciesControllers(context);
        }

        //Public variables to accept data being passed on from AdminGUI form

        //Action flag will be used to determine the correct course of action on this form, depending on which button is pressed on ADMINGUI. 
        public string ActionFlag { get; set; }

        public string LabelTitle { set { label_AgenciesTitle.Text = value; } }

        public int AgencyID { get; set; }

        public string AgencyAddress { set { textBox_AgencyAddress.Text = value; } }

        public string AgencyCity { set { textBox_AgencyCity.Text = value; } }

        public string AgencyProvince { set { comboBox_Province.Text = value; } }

        public string AgencyPostalCode { set { textBox_AgencyPostalCode.Text = value; } }

        public string AgencyCountry { set { textBox_AgencyCountry.Text = value; } }

        public string AgencyBusPhone { set { textBox_AgencyBusPhone.Text = value; } }

        public string AgencyFax { set { textBox_AgencyFaxPhone.Text = value; } }

        public string AgencyStatus { get; set; }




        //ON LOAD
        /*____________________________________________________________________________________________________________________________________________________________________ */

        private void frmAdminAgenciesManagement_Load_1(object sender, EventArgs e)
        {
            textBox_AgencyCountry.Enabled = false;

            if (ActionFlag == "Deletion")
            {
                //Setting textboxes to read only
                textBox_AgencyAddress.Enabled = false;
                textBox_AgencyBusPhone.Enabled = false;
                textBox_AgencyCity.Enabled = false;
                textBox_AgencyFaxPhone.Enabled = false;
                comboBox_Province.Enabled = false;
                textBox_AgencyPostalCode.Enabled = false;
            }
            else
            {
                textBox_AgencyAddress.Enabled = true;
                textBox_AgencyBusPhone.Enabled = true;
                textBox_AgencyCity.Enabled = true;
                textBox_AgencyFaxPhone.Enabled = true;
                comboBox_Province.Enabled = true;
                textBox_AgencyPostalCode.Enabled = true;
            }

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if ((ActionFlag == "Addition" || ActionFlag == "Modify") &&
                GenericValidations.IsPresent(textBox_AgencyAddress) &&
                GenericValidations.IsValidAddressInput(textBox_AgencyAddress) &&
                GenericValidations.IsPresent(textBox_AgencyCity) &&
                GenericValidations.IsValidAddressInput(textBox_AgencyCity) &&
                GenericValidations.IsComboBoxPresent(comboBox_Province) &&
                GenericValidations.IsPresent(textBox_AgencyPostalCode) &&
                GenericValidations.IsValidCanadianPostalCode(textBox_AgencyPostalCode) &&
                GenericValidations.IsPresent(textBox_AgencyBusPhone) &&
                GenericValidations.IsValidPhoneNumber(textBox_AgencyBusPhone) &&
                GenericValidations.IsPresent(textBox_AgencyFaxPhone) &&
                GenericValidations.IsValidPhoneNumber(textBox_AgencyFaxPhone))
            {
                if (ActionFlag == "Addition")
                {
                    HandleAgencyAdditon();
                }
                else if (ActionFlag == "Modify")
                {
                    HandleAgencyModify();
                }
                else if (ActionFlag == "Deletion")
                {
                    HandleAgencyDeletion();
                }
            }
        }

        private void HandleAgencyDeletion()
        {
            Agency agencyToDelete = new Agency
            {
                AgencyId = AgencyID,
                AgencyStatus = false
            };
            try
            {
                _agentsAndAgencies.DeleteAgency(agencyToDelete);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while deleting agency: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Agency: {ex.Message}");
            }
        }

        private void HandleAgencyModify()
        {
            Agency agencyToUpdate = new Agency
            {
                AgncyAddress = textBox_AgencyAddress.Text,
                AgncyCity = textBox_AgencyCity.Text,
                AgncyProv = comboBox_Province.Text,
                AgncyPostal = textBox_AgencyPostalCode.Text,
                AgncyCountry = textBox_AgencyCountry.Text,
                AgncyPhone = textBox_AgencyBusPhone.Text,
                AgncyFax = textBox_AgencyFaxPhone.Text,
                AgencyStatus = true
            };

            try
            {
                _agentsAndAgencies.UpdateAgency(agencyToUpdate);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while modifying Agency: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Modifying Agent: {ex.Message}");
            }
        }

        private void HandleAgencyAdditon()
        {
            Agency agencyToAdd = new Agency
            {
                AgncyAddress = textBox_AgencyAddress.Text,
                AgncyCity = textBox_AgencyCity.Text,
                AgncyProv = comboBox_Province.Text,
                AgncyPostal = textBox_AgencyPostalCode.Text,
                AgncyCountry = textBox_AgencyCountry.Text,
                AgncyPhone = textBox_AgencyBusPhone.Text,
                AgncyFax = textBox_AgencyFaxPhone.Text,
                AgencyStatus = true

            };


            try
            {
                _agentsAndAgencies.AddAgency(agencyToAdd);
                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error while adding Agency: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Agency: {ex.Message}");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
