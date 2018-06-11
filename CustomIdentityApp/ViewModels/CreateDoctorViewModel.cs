using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityApp.ViewModels
{
    public class CreateDoctorViewModel
    {
        public string Name { get; set; }
        //public string DoctorId { get; set; }
        public int Year { get; set; }
        public string Proffesion { get; set; }
    }
}