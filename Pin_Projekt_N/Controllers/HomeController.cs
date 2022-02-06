using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pin_Projekt_N.Data;
using Pin_Projekt_N.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pin_Projekt_N.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

  
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Ducan","Home");
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> Ducan()
        {
            return View(await _context.Artikl.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
        public IActionResult Kosarica()
        {
            
            return RedirectToAction("Ducan", "Home");
        }
    }
}
