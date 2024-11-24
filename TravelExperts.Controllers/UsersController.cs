using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public bool checkAdminStatus(Users user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null!");
            }

            try
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.username == user.username);

                if (existingUser == null)
                {
                    throw new InvalidOperationException("User cannot be found in the database");
                }

                // Return the Admin status of the existing user
                return existingUser.admin;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occurred while trying to retrieve the user", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred", ex);
            }
        }
    }
}
