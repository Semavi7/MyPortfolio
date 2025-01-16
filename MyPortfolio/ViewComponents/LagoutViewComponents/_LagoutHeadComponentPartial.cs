using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LogoutViewComponents
{
    public class _LagoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
