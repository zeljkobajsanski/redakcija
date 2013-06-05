using System.IO;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using Redakcija.WinClient.Models;
using Redakcija.WinClient.WebServices;
using Zeks.WinClientLibrary.Notifications;
using Zeks.WinClientLibrary.Views;
using Clanak = Redakcija.WinClient.Models.Clanak;

namespace Redakcija.WinClient.ViewModels
{
    public class EditorViewModel : ViewModelBase
    {
        public void PosaljiDokument(Document dokument)
        {
            using (var ms = new MemoryStream())
            {
                dokument.SaveDocument(ms, DocumentFormat.Rtf);
                ms.Seek(0, SeekOrigin.Begin);
                var clanak = new Clanak {Raw = ms.GetBuffer()};
                using (var svc = new TestServiceClient())
                {
                    svc.PosaljiClanakCompleted += (s, e) =>
                    {
                        OnSendNotification(new NotificationSaved());
                    };
                    svc.PosaljiClanakAsync(ObjectMapper.Map(clanak));
                }
            }
        }
    }
}