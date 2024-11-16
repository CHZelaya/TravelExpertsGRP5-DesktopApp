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
    public partial class frmAdminAgentsManagement : Form
    {
        public frmAdminAgentsManagement()
        {
            InitializeComponent();
        }

        //Public Variables to accept data from the AdminGUI Form
        
        //Action flag will be used to determine the correct course of action on this form, depending on which button is pressed on ADMINGUI. 
        public string ActionFlag { get; set; }
        public string LabelTitle
        {
            set { label_AgentsTitle.Text = value; }
        }

        // Passing Agent information from AdminGUI form and populating textboxes

        public string AgentID
        {
            set { textBox_AgentID.Text = value; }
        }
        public string AgencyID
        {
            set { textBox_AgencyID.Text = value; }
        }
        public string AgentFirstName
        {
            set { textBox_AgentFName.Text = value; }

        }

        public string AgentMiddleInitial
        {
            set { textBox_AgentMInitial.Text = value; }
        }

        public string AgentLastName
        {
            set { textBox_AgentLName.Text = value; }
        }

        public string AgentPhoneNumber
        {
            set { textBox_AgentBussPhone.Text = value; }
        }
        
        public string AgentEmail
        {
            set { textBox_AgentEmail.Text = value; }
        }

        public string AgentPosition
        {
            set { textBox_AgentPosition.Text = value; }
        }


    }
}
