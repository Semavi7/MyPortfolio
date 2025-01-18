using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.ViewModels;

namespace MyPortfolio.ViewComponents.LogoutViewComponents
{
    public class _LagoutNavbarComponentPartial : ViewComponent
    {
        MyPrtfolioContext context = new MyPrtfolioContext();
        public IViewComponentResult Invoke()
        {
            var viewModel = new NotificationViewModel
            {
                ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count(),
                UnreadMessageCount = context.Messages.Where(x => x.IsRead == false).Count(),
                ToDoList = context.ToDoLists.Where(x => x.Status == false).ToList(),
                UnreadMessages = context.Messages.Where(x => x.IsRead == false).ToList()
            };

            return View(viewModel);
        }
    }
}
