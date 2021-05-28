using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class PropertyChangedNotification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
