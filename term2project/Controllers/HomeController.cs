using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using term2project.Models;
using Microsoft.EntityFrameworkCore;
using term2project.Data;


namespace term2project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly ILogger<HomeController> _logger;

        /* public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         } */

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return _context.Cars != null ?
                        View(await _context.Cars.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Cars'  is null.");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}