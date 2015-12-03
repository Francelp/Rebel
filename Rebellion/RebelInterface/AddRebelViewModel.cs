using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelGooey
{
    public class AddRebelViewModel : INotifyPropertyChanged
    {
        private int _rebelId;
        public int rebelId
        {
            get { return _rebelId; }
            set { 
                _rebelId = value;
                onPropertyChanged("rebelId");
            }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value;
              On
            }
        }
        
        private int _territoryId;
        public int territoryId
        {
            get { return _territoryId; }
            set { _territoryId = value; onPropertyChanged("territoryId"); }
        }
        

        
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
