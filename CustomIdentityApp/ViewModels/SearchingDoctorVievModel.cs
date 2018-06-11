using CustomIdentityApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityApp.ViewModels
{
    public class SearchingDoctorVievModel
    {
        public Doctor doctor { get; set; }
        public SelectList Proffesion { get; set; }
        //public SelectList Year { get; set; }
    }
}