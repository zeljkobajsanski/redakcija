using System;
using System.ComponentModel;
using Zeks.WinClientLibrary.Annotations;
using Zeks.WinClientLibrary.Notifications;

namespace Zeks.WinClientLibrary.Views
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event EventHandler<NotificationEventArgs> SendNotification;
        
        protected virtual void OnSendNotification(Notification e)
        {
            var handler = SendNotification;
            if (handler != null)
            {
                handler(this, new NotificationEventArgs(e));
            }
        }
    }
}