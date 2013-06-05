using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Redakcija.WinClient.Properties;
using Zeks.WinClientLibrary.Notifications;
using Zeks.WinClientLibrary.Views;

namespace Redakcija.WinClient.Views
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            e.Control = GetView(e.Document.ControlName);
        }

        private ViewBase GetView(string viewName)
        {
            var view = new Editor();

            view.SendNotification += OnNotify;
            return view;
        }

        private void OnNotify(object sender, NotificationEventArgs notificationEventArgs)
        {
            switch (notificationEventArgs.Notification.NotificationType)
            {
                    case NotificationType.Info:
                        alertControl1.Show(this, "Info", notificationEventArgs.Notification.Message, Resources.info_32x32);
                        break;
                    case NotificationType.Warning:
                        alertControl1.Show(this, "Upozorenje", notificationEventArgs.Notification.Message, Resources.warning_32x32);
                        break;
                    case NotificationType.Error:
                        alertControl1.Show(this, "Greška", notificationEventArgs.Notification.Message, Resources.error_32x32);
                        break;
                    case NotificationType.Question:
                        notificationEventArgs.Confirmed = DialogResult.Yes ==
                                                          XtraMessageBox.Show(this, "Upit",
                                                                              notificationEventArgs.Notification.Message,
                                                                              MessageBoxButtons.YesNo,
                                                                              MessageBoxIcon.Question,
                                                                              MessageBoxDefaultButton.Button2);
                        break;
            }
        }
    }
}
