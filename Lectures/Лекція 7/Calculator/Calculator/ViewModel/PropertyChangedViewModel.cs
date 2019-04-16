using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.ViewModel
{
    public class PropertyChangedViewModel : INotifyPropertyChanged
    {
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
