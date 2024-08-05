using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfImagenes.Observable
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public ObservableObject()
        {

        }

        protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            field = value;
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
