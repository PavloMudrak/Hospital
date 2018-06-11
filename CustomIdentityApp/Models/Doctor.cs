using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityApp.Models
{
    public class Doctor
    {
        public string DoctorId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Proffesion { get; set; }
    }
}
