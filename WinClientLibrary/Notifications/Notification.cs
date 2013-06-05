namespace Zeks.WinClientLibrary.Notifications
{
    public class Notification
    {
        public NotificationType NotificationType { get; set; }

        public string Message { get; set; }

        public Notification(NotificationType notificationType, string message)
        {
            NotificationType = notificationType;
            Message = message;
        }
    }
}