using System;

namespace Zeks.WinClientLibrary.Notifications
{
    public class NotificationSaved : Notification
    {
         public NotificationSaved() : base(NotificationType.Info , "Podaci su uspešno sačuvani"){}
    }

    public class NotificationError : Notification
    {
        public NotificationError(Exception exception) : base(NotificationType.Error, exception.Message) { }
    }
}