using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts.Views
{
    public partial class frmAdminAgenciesManagement : Form
    {
        public frmAdminAgenciesManagement()
        {
            InitializeComponent();
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
    }
}
