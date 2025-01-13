using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
