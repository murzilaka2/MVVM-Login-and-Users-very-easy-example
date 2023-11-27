using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class UserViewModel
    {
        IList<UserDTO> _UserList;

        public UserViewModel()
        {
            _UserList = new List<UserDTO>()
            {
                new UserDTO{ FirstName = "Alex", LastName = "Beniwal", City = "Dehil", State = "Del", Country = "INIDIA" },
                new UserDTO{ FirstName = "Mark", LastName = "Mervel", City = "Dehil", State = "Del", Country = "CHINA" },
                new UserDTO{ FirstName = "Vika", LastName = "Hotsep", City = "Kumar", State = "Del", Country = "UK" },
                new UserDTO{ FirstName = "Bob", LastName = "Boberred", City = "Dehil", State = "Del", Country = "USA" },
                new UserDTO{ FirstName = "Tot", LastName = "Leviar", City = "Reetesh", State = "Del", Country = "POP" },
                new UserDTO{ FirstName = "Ravi", LastName = "Olkey", City = "Kolop", State = "Del", Country = "TAIWAN" }
            };
        }

        public IList<UserDTO> Users
        {
            get { return _UserList; }
            set { _UserList = value;}
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                {
                    mUpdater = new Updater();
                }
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                //...
            }
        }
    }
}
