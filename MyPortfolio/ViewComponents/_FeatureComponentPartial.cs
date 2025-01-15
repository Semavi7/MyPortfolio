using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPrtfolioContext portfolioContext = new MyPrtfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Fetures.ToList();
            return View(values);
        }
    }
}
