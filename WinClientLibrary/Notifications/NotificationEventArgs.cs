using System;

namespace Zeks.WinClientLibrary.Notifications
{
    public class NotificationEventArgs : EventArgs
    {
        public Notification Notification { get; set; }

        public bool Confirmed { get; set; }

        public NotificationEventArgs(Notification notification)
        {
            Notification = notification;
        }
    }
}