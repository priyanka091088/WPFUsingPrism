using Repository.Model;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee() {ID=1,FirstName="ABC",LastName="DEF",Email="ABC@gmal.com",Mobile="1234567890"},
                new Employee() {ID=1,FirstName="GHI",LastName="JKL",Email="GHI@gmal.com",Mobile="1234567890"},
                new Employee() {ID=1,FirstName="MNO",LastName="PQR",Email="MNO@gmal.com",Mobile="1234567890"},
                new Employee() {ID=1,FirstName="STU",LastName="VWX",Email="STU@gmal.com",Mobile="1234567890"}
            };
        }

    }
}
