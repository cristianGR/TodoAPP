using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TodoAPP.Model
{
    abstract class Notificable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                handler(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
