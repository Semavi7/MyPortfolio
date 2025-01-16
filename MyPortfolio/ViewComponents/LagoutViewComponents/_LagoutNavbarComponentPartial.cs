using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LogoutViewComponents
{
    public class _LagoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
