using Master_Detail.Data;
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
            return View();
        }
    }
}
