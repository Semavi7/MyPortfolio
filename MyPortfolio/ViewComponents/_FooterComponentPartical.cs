using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartical : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
