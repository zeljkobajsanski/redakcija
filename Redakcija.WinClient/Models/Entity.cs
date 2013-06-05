using System.ComponentModel;
using Redakcija.WinClient.Annotations;

namespace Redakcija.WinClient.Models
{
    public class Entity : INotifyPropertyChanged
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
    }
}