using CustomIdentityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityApp.ViewModels
{
    public class DoctorsData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Doctors.Any())
            {
                context.Doctors.AddRange(
                    new Doctor
                    {
                        Name = "Stepan",
                        DoctorId = "qqqqq1",
                        Year = 1984,
                        Proffesion = "Family doctor"
                    },
                   new Doctor
                   {
                       Name = "Roman",
                       DoctorId = "qqqqq2",
                       Year = 1973,
                       Proffesion = "Family doctor"
                   },
                    new Doctor
                    {
                        Name = "Stepan",
                        DoctorId = "qqqqq3",
                        Year = 1978,
                        Proffesion = "Family doctor"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
