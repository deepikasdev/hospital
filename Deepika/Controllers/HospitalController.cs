using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deepika.Models;
using Microsoft.AspNetCore.Mvc;

namespace Deepika.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllHospitals);
        }

        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Hospital hospital)
        {

            if (ModelState.IsValid)
            {
                Repository.Create(hospital);
                return View("Thanks", hospital);
            }
            else
                return View();
        }

        public IActionResult Update(string hospname)
        {
            Hospital hospital = Repository.AllHospitals.Where(h => h.Name == hospname).FirstOrDefault();
            return View(hospital);
        }

        [HttpPost]
        public IActionResult Update(Hospital hospital, string hospname)
        {
            if (ModelState.IsValid)
            {
                Repository.AllHospitals.Where(h => h.Name == hospname).FirstOrDefault().Name = hospital.Name;
                Repository.AllHospitals.Where(h => h.Name == hospname).FirstOrDefault().Address = hospital.Address;
                Repository.AllHospitals.Where(h => h.Name == hospname).FirstOrDefault().Speciality = hospital.Speciality;
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Delete(string hospname)
        {
            Hospital hospital = Repository.AllHospitals.Where(e => e.Name == hospname).FirstOrDefault();
            Repository.Delete(hospital);
            return RedirectToAction("Index");
        }
    }
}