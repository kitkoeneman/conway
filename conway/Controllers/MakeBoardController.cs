using Microsoft.AspNetCore.Mvc;

namespace conway.Controllers
{
    public class MakeBoardController : Controller
    {
        //
        // GET: /MakeBoard/
        public IActionResult Index(int height, int width)
        {
            return View();
        }
    }
}
