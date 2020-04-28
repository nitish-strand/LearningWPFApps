using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DotNetIsKool.Command;
using DotNetIsKool.Model;

namespace DotNetIsKool.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        // Constructors
        public PersonViewModel()
        {
            Person = new Person();
            Persons = new ObservableCollection<Person>();
        }

        // Properties : complexType
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set { _person = value; NotifyPropertyChanged("Person"); }
        }

        // Properties : ListType
        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                NotifyPropertyChanged("Persons");
            }
        }

        // Command
        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if(_SubmitCommand == null)
                {
                    _SubmitCommand = new MyCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _SubmitCommand;
            }
        }
        private void SubmitExecute(object parameter)
        {
            Persons.Add(Person);
        }

        private bool CanSubmitExecute(object parameter)
        {
            if(string.IsNullOrEmpty(Person.FName) || string.IsNullOrEmpty(Person.LName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // property change
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
