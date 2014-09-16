using Microsoft.Practices.Prism.ViewModel;
using Repository.Model;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModule.ViewModel
{
    public class EmployeeViewModel : NotificationObject
    {
        //public ICommand MyProperty { get; set; }
        private IEmployeeRepository iEmployeeRepository;

        public EmployeeViewModel(IEmployeeRepository IEmployeeRepository)
        {
            this.iEmployeeRepository = IEmployeeRepository;
            EmployeeList = new ObservableCollection<Employee>();
            Init();

        }

        private ObservableCollection<Employee> _employeeList;
        public ObservableCollection<Employee> EmployeeList
        {
            get { return _employeeList; }
            set { _employeeList = value; RaisePropertyChanged("EmployeeList"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Init()
        {
            var emps = iEmployeeRepository.GetAllEmployees();
            foreach (Employee item in emps)
            {
                EmployeeList.Add(item);
            }

        }
    }
}
