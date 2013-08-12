using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace UserControlPattern
{
    public class ModelObject: INotifyPropertyChanged
    {
        private int _boxheight;

        public int BoxHeight
        {
            get { return _boxheight; }
            set
            {
                _boxheight = value;
                OnPropertyChanged("BoxHeight");
            }
        }

        private double _boxwidth;

        public double BoxWidth
        {
            get { return _boxwidth; }
            set
            {
                _boxwidth = value;
                OnPropertyChanged("BoxWidth");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
