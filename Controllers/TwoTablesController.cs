using Master_Detail.Data;
using Master_Detail.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Master_Detail.Controllers
{
    public class TwoTablesController : Controller
    {

        public readonly AppDbContext _db;

        public TwoTablesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            TwoTables two = new TwoTables();

            two.applicants = _db.applicants.ToList();

            two.expriences = _db.expriences.ToList();

            return View(two);
        }
    }
}
