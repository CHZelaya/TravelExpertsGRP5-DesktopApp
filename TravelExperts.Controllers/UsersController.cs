using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperts.Models.Models;

namespace TravelExperts.Controllers
{


    public class UsersController
    {
        private readonly TravelExpertsContext _context;

        public UsersController(TravelExpertsContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Check user role
        /// </summary>
        /// <param name="userToCheck"></param>
        /// <param name="message"></param>
        /// <returns>Welcome message with Admin or User depending on privileges</returns>
        public bool CheckUserPrivileges(Users userToCheck, out string? message)
        {
            if (userToCheck == null) 
            {
                message = "User to check cannot be empty";
                return false;
            }

            var checkAdmin = _context.Users.FirstOrDefault(u => u.username == userToCheck.username);

            // Check if the user exists
            if (checkAdmin == null)
            {
                message = "User not found";
                return false;
            }

            // Check if the user is an admin
            if (checkAdmin.admin == true) // Assuming admin is a bit column where 1 means admin
            {
                message = "Welcome Back Admin";
                return true;
            }
            else
            {
                message = "Welcome Back User";
                return false;
            }

        }

        public bool ValidateUserCredentials(Users usersToCheck, out string? message)
        {
            if (usersToCheck == null)
            {
                message = "User to check cannot be empty";
                return false ;
            }
            //Logging for debugging
            Debug.WriteLine($"Attempting to login for Username: {usersToCheck.username}, Password: {usersToCheck.password}");
            //var existingUser = _context.Users.Find(usersToCheck.username, usersToCheck.password);
            var existingUser = _context.Users.FirstOrDefault(u => u.username == usersToCheck.username && u.password == usersToCheck.password);

            if (existingUser == null)
            {
                message = "Incorrect Credentials";
                return false;
            }

            message = "Login Successful";
            return true;
        }
    }//class
}//namespace
