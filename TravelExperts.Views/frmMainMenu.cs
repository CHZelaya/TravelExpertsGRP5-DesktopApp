using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Views.Utils;

namespace TravelExperts.Views
{

    public partial class frmMainMenu : Form
    {
        private Button activeButton = null;
        private Form activeForm;
        private string actionFlag;


        //Constructor
        public frmMainMenu(string actionFlag)
        {
            InitializeComponent();
            InitializeButtons();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.actionFlag = actionFlag;
            configureMenuOptions();

        }

        private void configureMenuOptions()
        {
            if (actionFlag == "admin")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
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

            // Set up the new child form
            this.panelDesktopPanel.Controls.Clear(); // Clear existing controls
            childForm.TopLevel = false;
            activeForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Clear previous controls and add the new child form
            this.panelDesktopPanel.Controls.Clear();
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            this.panelDesktopPanel.Visible = true;

            // Bring the child form to the front and show it
            childForm.BringToFront();
            childForm.Show();

            // Update the title and visibility of the close button
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
                activeButton.Font = new Font("Palatino Linotype", 18, FontStyle.Regular);
                panelTitleBar.BackColor = ThemeColor.CharcoalGray;
                panelLogo.BackColor = ThemeColor.CharcoalGray;
            }

            //Activate the new button
            button.BackColor = color;
            //Change button font
            button.Font = new Font("Palatino Linotype", 20, FontStyle.Bold);
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
            panelLogo.BackColor = ThemeColor.CharcoalGray;
            activeButton.BackColor = ThemeColor.CharcoalGray;
            activeButton.Font = new Font("Palatino Linotype", 18, FontStyle.Regular);
            activeButton.ForeColor = Color.White;


        }

        private void ToggleViews(Form targetForm)
        {
            // Close the currently active form if it exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Clear previous controls and set up the new child form
            this.panelMain.Controls.Clear(); // Clear existing controls
            targetForm.TopLevel = false;
            activeForm = targetForm;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.Dock = DockStyle.Fill;

            // Add the new child form to the main panel
            this.panelMain.Controls.Add(targetForm);
            this.panelMain.Tag = targetForm;
            this.panelMain.Visible = true;

            // Bring the child form to the front and show it
            targetForm.BringToFront();
            targetForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

           
            // Show the confirmation dialog and capture the result
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                // Perform logout actions
                panelLogo.Visible = false;
                panelTitleBar.Visible = false;
                panelMenu.Visible = false;
                ToggleViews(new LoginForm());
            }
        }
    }//class
}//namespace
