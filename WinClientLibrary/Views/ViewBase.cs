using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zeks.WinClientLibrary.Notifications;

namespace Zeks.WinClientLibrary.Views
{
    public class ViewBase : XtraForm
    {
        private bool m_IsBusy;
        public event EventHandler<NotificationEventArgs> SendNotification;

        public bool UseBusyCursor { get; set; }

        public bool IsBusy
        {
            get { return m_IsBusy; }
            set
            {
                if (IsBusy == value) return;
                m_IsBusy = value;
                if (UseBusyCursor)
                {
                    Cursor = IsBusy ? Cursors.WaitCursor : Cursors.Default;
                }
            }
        }

        protected virtual void OnSendNotification(Notification e)
        {
            var handler = SendNotification;
            if (handler != null)
            {
                handler(this, new NotificationEventArgs(e));
            }
        }

        protected void HandleError(Exception exception)
        {
            OnSendNotification(new NotificationError(exception));
        }

        public virtual bool ImplementiranNoviUnos { get { return false; } }

        public virtual void NoviUnos() {}

        public virtual bool ImplementiranoOsvezi { get { return false; } }

        public virtual void Osvezi() { }

        public virtual bool ImplementiranoSacuvaj { get { return false; } }

        public virtual void Sacuvaj() { }
    }
}