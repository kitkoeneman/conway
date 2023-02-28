using Microsoft.AspNetCore.Mvc;

namespace conway.Controllers
{
    public class FillBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
