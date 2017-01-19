using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDetailsWebApp.Model;
namespace EmployeeDetailsWebApp
{
    public class EmployeeController
    {
        private IEmployeeRepositoryInterface employeeRepository;
        public EmployeeController(IEmployeeRepositoryInterface employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public int CreateNewEmployee(Employee employee)
        {
            int status;
            if (CheckIfFirstNameOrLastNameOrEmailIsNullOrEmpty(employee))
                status = 0;
            else
                status = employeeRepository.InsertEmployeeById(employee);
            return status;
        }

        private static bool CheckIfFirstNameOrLastNameOrEmailIsNullOrEmpty(Employee employee)
        {
            return string.IsNullOrEmpty(employee.FirstName) || string.IsNullOrEmpty(employee.LastName) || string.IsNullOrEmpty(employee.EmailId);
        }

        public Employee RetrieveEmployee(Employee employee)
        {
            return employeeRepository.GetEmployeeById(employee.Id);
        }
        public List<Employee> RetrieveEmployees()
        {
            return employeeRepository.GetEmployees();
        }
        public int EditEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployeeById(employee.Id);
        }
        public int DeleteEmployee(Employee employee)
        {
            return employeeRepository.DeleteEmployeeById(employee.Id);
        }
    }
}