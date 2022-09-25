using Master_Detail.Data;
using Master_Detail.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Master_Detail.Controllers
{
    public class ResumeController : Controller
    {
        private readonly AppDbContext _db;

        public ResumeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Applicant> applicants;

            applicants = _db.applicants.ToList();

            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        { 

            Applicant applicant = new Applicant();

            applicant.Experiences.Add(new Exprience() { ExperienceId = 1 });
            //applicant.Experiences.Add(new Exprience() { ExperienceId = 2 });
            //applicant.Experiences.Add(new Exprience() { ExperienceId = 3 });
            //applicant.Experiences.Add(new Exprience() { ExperienceId = 4 });

            return View(applicant);
        }

        public IActionResult Create(Applicant applicant)
        {
            foreach(Exprience exprience in applicant.Experiences)
            {
                if(exprience.CompanyName==null || exprience.CompanyName.Length == 0)
                {
                    applicant.Experiences.Remove(exprience);
                }


            }

            _db.applicants.Add(applicant);
            _db.SaveChanges();
             return RedirectToAction("Index");
        }
    }
}
