using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace conway.Controllers;

public class NewGameController : Controller
{
    // 
    // GET: /NewGame/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}