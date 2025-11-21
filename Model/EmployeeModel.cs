using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class EmployeeModel : INotifyPropertyChanged
    {
        private int id;
        public int Id { get
            {
                return id;
            }
            set {
                id = value;
                onPropertyChanged("Id");
            }
        }

        private string name;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
                onPropertyChanged("Name");
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                onPropertyChanged("Password");
            }
        }
      

        private int age;
        public int Age { 
            get
            { return age; } 
            set 
            {
                age = value;
                onPropertyChanged("Age");
            } }

        public event PropertyChangedEventHandler PropertyChanged;


        private void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
            }
        }

        
    }
}
