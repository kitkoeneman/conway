using conway.Models;
using Microsoft.AspNetCore.Mvc;

namespace conway.Controllers
{
    public class GameBoardController : Controller
    {
        [HttpPost]
        public IActionResult FillBoard(GameBoard makeBoardRequest)
        {
            if (ModelState.IsValid)
            {
                var boardViewModel = new GameBoard()
                {
                    Height = makeBoardRequest.Height,
                    Width = makeBoardRequest.Width,
                };
                return View(boardViewModel);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
