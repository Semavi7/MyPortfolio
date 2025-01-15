using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperinceComponentPartial : ViewComponent
    {
        MyPrtfolioContext context = new MyPrtfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Esperiences.ToList();
            return View(values);
        }
    }
}
