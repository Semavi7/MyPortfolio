using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartical : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
