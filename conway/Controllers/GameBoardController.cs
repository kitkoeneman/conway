using conway.Models;
using Microsoft.AspNetCore.Mvc;

namespace conway.Controllers
{
    public class GameBoardController : Controller
    {
        static GameBoard? boardViewModel;

        [HttpPost]
        public IActionResult FillBoard(GameBoard makeBoardRequest)
        {
            if (ModelState.IsValid)
            {
                boardViewModel = new GameBoard()
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
