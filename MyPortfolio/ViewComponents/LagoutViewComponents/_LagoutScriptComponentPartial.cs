using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LagoutViewComponents
{
    public class _LagoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
