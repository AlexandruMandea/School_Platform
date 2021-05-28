using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPlatform.Models.Entities
{
    class LinkingTable :PropertyChangedNotification
    {
        private int id1;
        private int id2;

        public int ID1
        { 
            get
            {
                return id1;
            }
            set
            {
                id1 = value;
                NotifyPropertyChanged("ID1");
            }
        }

        public int ID2
        {
            get
            {
                return id2;
            }
            set
            {
                id2 = value;
                NotifyPropertyChanged("ID2");
            }
        }
    }
}
