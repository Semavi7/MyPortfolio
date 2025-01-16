using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LagoutViewComponents
{
    public class _LagoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
