using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    public class EmployeeModelServices
    {
      public  static List<EmployeeModel> ObjemployeesList;
        public EmployeeModelServices()
        {

            ObjemployeesList = new List<EmployeeModel>()
            {
                new EmployeeModel
                {
                    Id = 1, Age = 20, Name="Anuj", Password = "Anuj", PhoneNumber="12345"
                },
                new EmployeeModel
                {
                    Id = 2, Age = 20, Name="Shivam", Password = "shivam", PhoneNumber="23456"
                }

            };

        }


        #region GetAllData
        public List<EmployeeModel> GetAllData()
        {
            return ObjemployeesList;
        }
        #endregion

        #region AddEmployeeDetails
        public bool AddNewEmployee(EmployeeModel newEmp)
        {
            bool addedValue = false;
            //for(int i = 0; i < ObjemployeesList.Count; i++)
            //{
            //    if (ObjemployeesList[i].Id == newEmp.Id)
            //    {
            //        MessageBox.Show("Id is already existed");
            //        return addedValue;
            //    }
            //}
            EmployeeModel newEmp1 = new EmployeeModel
            {
                Id = newEmp.Id,
                Age = newEmp.Age,
                Name = newEmp.Name,
                Password = newEmp.Password,
                PhoneNumber = newEmp.PhoneNumber,

            };

            ObjemployeesList.Add(newEmp1);
            addedValue = true;
            return addedValue;
        }
        #endregion


        public bool DeleteEmployee(EmployeeModel existEmp) 
        {
            bool deletedval = false;
            //var deleteval = ObjemployeesList.Remove(existEmp); 
           for(int i=0; i< ObjemployeesList.Count; i++)
            {
                if(ObjemployeesList[i].Id == existEmp.Id)
                {
                    ObjemployeesList.RemoveAt(i);
                    deletedval = true;
                }
            }
            return deletedval;
        }
        public bool UpdateEmployeeDetails(EmployeeModel newEmp) {
            bool updateval = false;
            return updateval;
        }
    }
}
