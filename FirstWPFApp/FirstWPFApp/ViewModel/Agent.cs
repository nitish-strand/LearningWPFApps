using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPFApp.ViewModel
{
    public class Agent : INotifyPropertyChanged
    {
        Model obj = new Model();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            if(propertyName != "Info")
            OnPropertyChanged("Info");
        }

        private string _fname;
        private string _lname;
        private int _age;
        public string Fname
        {
            get { return _fname; }
            set
            {
                _fname = value;
                OnPropertyChanged("Fname");
            }
        }

        public string Lname
        {
            get { return _lname; }
            set
            {
                _lname = value;
                OnPropertyChanged("Lname");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Info
        {
            get
            {
                return obj.GetInfo(Fname, Lname, Age);
            }
        }
    }
}
