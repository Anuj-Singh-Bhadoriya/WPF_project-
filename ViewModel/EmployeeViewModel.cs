using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Command;
using WpfApp1.Model;
using System.Collections.ObjectModel;

namespace WpfApp1.ViewModel
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        

        EmployeeModelServices ObjemployeeServices;
         public EmployeeViewModel() {
            ObjemployeeServices = new EmployeeModelServices();
            LoadData();
            CurrEmployee = new EmployeeModel();
            savecommand = new RelayCommand(SaveNewEmployee);
            deletecommand = new RelayCommand(DeleteEmployee);
          
        }


        #region Display Employee
        private ObservableCollection<EmployeeModel> employeelist;
        public ObservableCollection<EmployeeModel> EmployeeList
        {
            get{
                return employeelist;
            }
            set{
                employeelist = value;
                onPropertyChanged("EmployeeList");
            }

        }

        public void LoadData()
        {
            EmployeeList = new ObservableCollection<EmployeeModel>(ObjemployeeServices.GetAllData());
        }

        #endregion


        #region Add New Employee details

        private EmployeeModel curremployee;
        public EmployeeModel CurrEmployee
        {
            get { return curremployee; }
            set { curremployee = value; onPropertyChanged("CurrEmployee"); }
         }

        private RelayCommand savecommand;
        public RelayCommand SaveCommand
        {
            get { return savecommand;  }
        }


        public void SaveNewEmployee()
        {
            try
            {
                if (curremployee != null)
                {
                   bool val =  ObjemployeeServices.AddNewEmployee(curremployee);
                    if (val)
                    {
                        LoadData();    // refresh display data after changes
                        MessageBox.Show("Save Successfully");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter new Employee Details");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        #endregion

        #region DeleteEmployee
        private RelayCommand deletecommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deletecommand;
            }
        }
        public void DeleteEmployee()
        {
            var val = ObjemployeeServices.DeleteEmployee(curremployee);
            if (val)
            {
                MessageBox.Show("deleted Successfully");
                LoadData();
            }

        }

        #endregion



    }
}
