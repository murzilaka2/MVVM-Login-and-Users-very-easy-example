
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        private User user;
        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public User UserData
        {
            get
            {
                return user;
            }
        }
        public string UserName
        {
            get
            {
                return user.UserName;
            }
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get
            {
                return user.Password;
            }
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void LoggedIn(object param)
        {
            User user = param as User;
            if (user.UserName != null && user.Password != null && user.UserName.Equals("admin@gmail.com") && user.Password.Equals("qwerty"))
            {
                MessageBox.Show($"Welcome, {user.UserName}!");
            }
            else
            {
                MessageBox.Show($"Wrong login or password!");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
