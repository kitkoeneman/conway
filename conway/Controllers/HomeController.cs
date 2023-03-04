using conway.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace conway.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeBoard(GameBoard makeBoardRequest)
        {
            if (ModelState.IsValid)
            {
                var GameBoard = new GameBoard()
                {
                    Height = makeBoardRequest.Height,
                    Width = makeBoardRequest.Width,
                };
            }
            return RedirectToAction("FillBoard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}