using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }

        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
