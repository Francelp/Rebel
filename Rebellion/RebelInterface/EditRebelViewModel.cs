﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelGooey
{
    class EditRebelViewModel : INotifyPropertyChanged
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value;
            onPropertyChanged("name");
            }
        }
        

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value;
            onPropertyChanged("name");}
        }

        private string _surname;
        public string surname
        {
            get { return _surname; }
            set { _surname = value; onPropertyChanged("surname"); }
        }

        private string _emailAddress;
        public string emailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; onPropertyChanged("emailAddress"); }
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
