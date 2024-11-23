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

    public partial class frmMainMenu : Form
    {
        private Button activeButton = null;
        private Form activeForm;

        //Constructor
        public frmMainMenu()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {   //Assign default colors of CharcoalGray to all buttons
            btnAdmin.BackColor = ThemeColor.CharcoalGray;
            btnLogOut.BackColor = ThemeColor.CharcoalGray;
            btnPackages.BackColor = ThemeColor.CharcoalGray;
            btnSuppliers.BackColor = ThemeColor.CharcoalGray;

            //Event Listeners to apply colors when active
            btnAdmin.Click += (sender, e) => ActivateButton(btnAdmin, ThemeColor.DodgerBlue);
            btnLogOut.Click += (sender, e) => ActivateButton(btnLogOut, ThemeColor.SunsetOrange);
            btnPackages.Click += (sender, e) => ActivateButton(btnPackages, ThemeColor.SoftGreen);
            btnSuppliers.Click += (sender, e) => ActivateButton(btnSuppliers, ThemeColor.DustyBlue);
        }


        //Methods

        //Method to fill the panelDesktopPanel with the forms

        private void OpenChildrenForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            activeForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            this.panelDesktopPanel.Visible = true;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = GetUserFriendlyTitle(childForm.GetType().Name);
            btnCloseChildForm.Visible = true;

        }

        // Helper Function to be called to make the Titles more user friendly

        private string GetUserFriendlyTitle(string formName)
        {
            switch (formName)
            {
                case "AdminGUIMain":
                    return "Admin Dashboard";
                case "ProductSuppliesForm":
                    return "Suppliers";
                case "PackageMaintenance":
                    return "Packages";
                default:
                    return "Unknown Form";
            }
        }

        //Helper Function to be called in ActivateButton that will darken the LogoPanel slightly
        private Color DarkenColor(Color color, float factor)
        {
            int r = (int)(color.R * factor);
            int g = (int)(color.G * factor);
            int b = (int)(color.B * factor);
            return Color.FromArgb(r, g, b);
        }
        private void ActivateButton(Button button, Color color)
        {
            if (activeButton != null && activeButton != button)
            {
                activeButton.BackColor = ThemeColor.CharcoalGray;
                activeButton.ForeColor = Color.White;
                activeButton.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);
                panelTitleBar.BackColor = ThemeColor.CharcoalGray;
                panelLogo.BackColor = ThemeColor.CharcoalGray;
            }

            //Activate the new button
            button.BackColor = color;
            //Change button font
            button.Font = new Font("Palatino Linotype", 15, FontStyle.Bold);
            button.ForeColor = Color.Black;
            activeButton = button;

            //Change titlePanel color to match button
            panelTitleBar.BackColor = color;

            //Call method to darken logo panel
            panelLogo.BackColor = DarkenColor(color, 0.7f);


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new AdminGUIMain(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked");
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new PackageMaintenance(), sender);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new ProductSuppliesForm(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                ResetMainMenu();
            }
        }

        private void ResetMainMenu()
        {
            btnCloseChildForm.Visible = false; 
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = ThemeColor.CharcoalGray;
            panelLogo.BackColor= ThemeColor.CharcoalGray;
            activeButton.BackColor = ThemeColor.CharcoalGray;
            activeButton.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);
            activeButton.ForeColor = Color.White;


        }
    }
}
