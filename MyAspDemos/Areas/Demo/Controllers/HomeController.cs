using Microsoft.AspNetCore.Mvc;

namespace MyAspDemos.Areas.Demo.Controllers
{
    [Area("Demo")]                  // Register the Route for the Controller to the Area
    public class HomeController : Controller
    {
        // HTTP GET https://localhost:xxxx/Demo/Home/Index
        // ROUTE: url / {area} / {controller} / {action}
        public IActionResult Index()
        {
            return Ok("Hello world");               // HTTP Response 200 "Ok"
        }
    }
}
