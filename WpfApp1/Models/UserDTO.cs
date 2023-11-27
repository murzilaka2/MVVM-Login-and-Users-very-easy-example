using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class UserDTO : INotifyPropertyChanged
    {
        private int id;
        private static int _id;
        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private string country;

        public UserDTO()
        {
            id = ++_id;
        }

        #region INotifyPropertyChanged Member
        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        public string State
        {
            get => state;
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
        }
        public string Country
        {
            get => country;
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        #endregion


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
