using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts.Models.Models
{
    public class Users
    {
        [Key]
        public int user_id { get; set; } // Corresponds to user_id in the database
        public string username { get; set; } // Corresponds to username
        public string password { get; set; } // Corresponds to password
        public bool admin { get; set; } // Corresponds to admin
    }
}
