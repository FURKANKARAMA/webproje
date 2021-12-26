using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webproje2021.Data;
using webproje2021.Models;

namespace webproje2021.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var db = _context.urunler;
            return View(db.ToList());
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
           
            return View();
        }
        
     


    }
}
