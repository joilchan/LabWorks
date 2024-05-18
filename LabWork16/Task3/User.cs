using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16
{
    internal class User : INotifyPropertyChanged
    {
        string login;
        string password;

        public string Login
        {
            get => login;
            set
            {
                login = value;
                NotifyPropertyChanged();
                Notify?.Invoke(this, EventArgs.Empty);
                Info?.Invoke(this, new InfoEventArgs());
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                NotifyPropertyChanged();
                Notify?.Invoke(this, EventArgs.Empty);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event EventHandler Notify;

        public event EventHandler<InfoEventArgs> Info;

    }
}
