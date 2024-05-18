using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork16
{
    internal class InfoEventArgs : EventArgs
    {
        private string _name;
        public string Name;
        public string nameProperty
        {
            get {  return _name; }
            set 
            {
                if(_name != value)
                {
                    _name = value;
                    PropertyChangedEventArgs?.Invoke(this, new InfoEventArgs();
                }
            } 
        }
        public string textError { get; set; }
        public DateTime dateChanged {  get; set; }
    }
}
