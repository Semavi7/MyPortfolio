using MyPortfolio.DAL.Entities;

namespace MyPortfolio.ViewModels
{
    public class NotificationViewModel
    {
        public int ToDoListCount { get; set; }
        public int UnreadMessageCount { get; set; }
        public int TotalNotifications => ToDoListCount + UnreadMessageCount;
        public List<ToDoList> ToDoList { get; set; }
        public List<Message> UnreadMessages { get; set; }
    }
}
