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

        public string AgencyID { set { textBox_AgencyID.Text = value; } }

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
            throw new NotImplementedException();
        }

        private void HandleAgencyModify()
        {
            throw new NotImplementedException();
        }

        private void HandleAgencyAdditon()
        {
            throw new NotImplementedException();
        }
    }


}
