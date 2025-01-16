using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPrtfolioContext context = new MyPrtfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead==false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead==true).Count();
            return View();
        }
    }
}
