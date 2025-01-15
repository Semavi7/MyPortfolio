using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPrtfolioContext PrtfolioContext = new MyPrtfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=PrtfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=PrtfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=PrtfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
