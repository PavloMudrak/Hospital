using CustomIdentityApp.Models;
using CustomIdentityApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace CustomIdentityApp.Controllers
{

    public class DoctorsController : Controller
    {

        ApplicationContext db;
        public DoctorsController(ApplicationContext context)
        {
            db = context;
        }

        public ViewResult Index(string searchString)
        {
            var doctors = from s in db.Doctors
                          select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                doctors = doctors.Where(s => s.Proffesion.ToUpper().Contains(searchString.ToUpper()));

            }

            return View(doctors);
        }

        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Create1() => View();

        [HttpPost]
        public async Task<IActionResult> Create1(Doctor doctor)
        {


            var result = db.Doctors.Add(doctor);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");


        }



        [HttpPost]
        public IActionResult Delete(string id)
        {
            Doctor doctor = db.Doctors.Find(id);
            if (doctor != null)
            {
                db.Doctors.Remove(doctor);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
