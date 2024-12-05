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

            //First checking to see if the user is valid. 
            if (!CheckValidUser())
            {
                return; // Exit if user is not valid
            }

            //If valid, check privileges
            CheckUserPrivileges();

        }


        /// <summary>
        /// Checks to see if the user is a valid user
        /// </summary>
        /// <returns>True if user is found, false if no user is found.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private bool CheckValidUser()
        {
            //First checking to see if fields are empty
            if (string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; //False will prevent login
            }

            if (_usersController == null) 
            {
                throw new InvalidOperationException("UserController is not initialized.");
            }
            Users usersToCheck = new Users
            {
                username = txt_username.Text,
                password = txt_password.Text,
            };

            string message;
            bool isValidUser = _usersController.ValidateUserCredentials(usersToCheck, out message);
            
            //Messagebox for user
            MessageBox.Show(message, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return isValidUser;

        }


        /// <summary>
        /// Checks if user is admin or not.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CheckUserPrivileges()
        {
            Users userToCheck = new Users
            {
                username = txt_username.Text
            };

            string message; // Variable to hold the message from CheckUserPrivileges
            bool isAdmin = _usersController.CheckUserPrivileges(userToCheck, out message); //Check admin status

            //Show message 
            MessageBox.Show(message, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information );

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




            //bool isValidUser = CheckPrivledges();

            //if (!isValidUser) 
            //{
            //    //exit the method of the user is not valid
            //    return;
            //}

            ////If valid, check to see if they are admin or user

            //Users userToCheck = new Users
            //{
            //    username = txt_username.Text,
            //    password = txt_password.Text,
            //};

            //string message;
            //bool isAdmin = _usersController.checkAdminStatus(userToCheck, userToCheck.password, out message);
            ////check admin status

            ////Show the message, whatever it may be, to the user
            //MessageBox.Show(message, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //if (isAdmin)
            //{
            //    string actionFlag = "admin";
            //    ToggleViews(new frmMainMenu(actionFlag));
            //    pictureBoxTop.Visible = false;
            //    panelRight.Visible = false;
            //    panelLeft.Visible = false;
            //}
            //else
            //{
            //    string actionFlag = "user";
            //    ToggleViews(new frmMainMenu(actionFlag));
            //}
        //}

        //private bool CheckPrivledges()
        //{
        //    if (string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_username.Text))
        //    {
        //        MessageBox.Show("Please enter both username and password.", "Input Error");
        //        return false;
        //    }
        //    if (_usersController == null)
        //    {
        //        throw new InvalidOperationException("UsersController is not initialized.");
        //    }
        //    Users userToCheck = new Users
        //    {
        //        username = txt_username.Text,
        //        password = txt_password.Text,
        //    };

        //    string message;
        //    bool result = _usersController.checkAdminStatus(userToCheck, userToCheck.password, out message);
        //    MessageBox.Show(message, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    return result;
        //}

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
