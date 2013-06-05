using System.ComponentModel;
using DevExpress.XtraEditors.DXErrorProvider;
using FluentValidation.Results;
using Redakcija.WinClient.Annotations;
using System.Linq;

namespace Redakcija.WinClient.Models
{
    public class Entity : INotifyPropertyChanged, IDXDataErrorInfo
    {
        public int ID { get; set; }
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

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            var errors = GetErrors();
            var fe = errors.Errors.FirstOrDefault(x => x.PropertyName == propertyName);
            info.ErrorText = fe != null ? fe.ErrorMessage : null;
        }

        public void GetError(ErrorInfo info)
        {
            var errors = GetErrors();
            info.ErrorText = !errors.IsValid ? "Podaci nisu validni, molim ispravite ih" : null;
        }

        protected virtual ValidationResult GetErrors()
        {
            return  new ValidationResult();
        }
    }
}