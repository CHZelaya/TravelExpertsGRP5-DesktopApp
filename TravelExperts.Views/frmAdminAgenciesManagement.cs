using Microsoft.EntityFrameworkCore;
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

        public int AgencyID {  get; set; }

        public string AgencyAddress { set { textBox_AgencyAddress.Text = value; } }

        public string AgencyCity { set { textBox_AgencyCity.Text = value; } }

        public string AgencyProvince { set { textBox_AgencyProvince.Text = value; } }

        public string AgencyPostalCode { set { textBox_AgencyPostal.Text = value; } }

        public string AgencyCountry { set { textBox_AgencyCountry.Text = value; } }

        public string AgencyBusPhone { set { textBox_AgencyBusPhone.Text = value; } }

        public string AgencyFax { set { textBox_AgencyFaxPhone.Text = value; } }




        //ON LOAD
        /*____________________________________________________________________________________________________________________________________________________________________ */

        private void frmAdminAgenciesManagement_Load_1(object sender, EventArgs e)
        {
            if (ActionFlag == "Deletion")
            {
                //Setting textboxes to read only
                textBox_AgencyAddress.Enabled = false;
                textBox_AgencyBusPhone.Enabled = false;
                textBox_AgencyCity.Enabled = false;
                textBox_AgencyCountry.Enabled = false;
                textBox_AgencyFaxPhone.Enabled = false;
                textBox_AgencyPostal.Enabled = false;
                textBox_AgencyProvince.Enabled = false;
            }
            else
            {
                textBox_AgencyAddress.Enabled = true;
                textBox_AgencyBusPhone.Enabled = true;
                textBox_AgencyCity.Enabled = true;
                textBox_AgencyCountry.Enabled = true;
                textBox_AgencyFaxPhone.Enabled = true;
                textBox_AgencyPostal.Enabled = true;
                textBox_AgencyProvince.Enabled = true;
            }

        }

        private void button_OK_Click(object sender, EventArgs e)
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



        private void HandleAgencyDeletion()
        {
            MessageBox.Show("Not handled yet, need to implement 'status' for Agencies as to not permenantly delete them from the database");
        }

        private void HandleAgencyModify()
        {
            Agency agencyToUpdate = new Agency
            {
                AgncyAddress = textBox_AgencyAddress.Text,
                AgncyCity = textBox_AgencyCity.Text,
                AgncyProv = textBox_AgencyAddress.Text,
                AgncyPostal = textBox_AgencyPostal.Text,
                AgncyCountry = textBox_AgencyCountry.Text,
                AgncyPhone = textBox_AgencyBusPhone.Text,
                AgncyFax = textBox_AgencyFaxPhone.Text
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
                AgncyProv = textBox_AgencyAddress.Text,
                AgncyPostal = textBox_AgencyPostal.Text,
                AgncyCountry = textBox_AgencyCountry.Text,
                AgncyPhone = textBox_AgencyBusPhone.Text,
                AgncyFax = textBox_AgencyFaxPhone.Text

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


    }


}
