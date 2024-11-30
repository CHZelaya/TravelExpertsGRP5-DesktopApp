using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExperts.Models.Models;
using TravelExperts.Controllers;
using TravelExperts.Views.Utils;

namespace TravelExperts.Views
{
    public partial class LoginForm : Form
    {
        private Form activeForm;
        private TravelExpertsContext _context;
        private UsersController _usersController;

        public LoginForm()
        {
            InitializeComponent();
            RoundButton roundButton = new RoundButton();
            roundButton.RoundExistingButton(btn_login);
            roundButton.RoundExistingButton(btnExit);
            _context = new TravelExpertsContext();
            _usersController = new UsersController(_context);
            this.WindowState = FormWindowState.Maximized; // Set the window to start maximized
            panelLeft.Visible = true;
            panelRight.Visible = true;
            pictureBoxTop.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isAdmin = CheckPrivledges();
            //add validation for login without any input vlaues
            if (isAdmin)
            {
                string actionFlag = "admin";
                ToggleViews(new frmMainMenu(actionFlag));
                pictureBoxTop.Visible = false;
                panelRight.Visible = false;
                panelLeft.Visible = false;
            }
            else
            {
                string actionFlag = "user";
                ToggleViews(new frmMainMenu(actionFlag));
            }
        }

        private bool CheckPrivledges()
        {
            if (_usersController == null)
            {
                throw new InvalidOperationException("UsersController is not initialized.");
            }
            Users userToCheck = new Users
            {
                username = txt_username.Text,
            };

            bool result = _usersController.checkAdminStatus(userToCheck);
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                                                  "Confirm Exit",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

            // Update the title and visibility of the close button
            //labelTitle.Text = GetUserFriendlyTitle(targetForm.GetType().Name);
            //btnCloseChildForm.Visible = true;
        }
    }
}
