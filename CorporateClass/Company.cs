using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }

        private List<Employees> _currentEmployees = new List<Employees>();

        public void AddEmployee(Employees newEmployee)
        {
            _currentEmployees.Add(newEmployee);
        }

        public void RemoveEmployee(Employees oldEmployee)
        {
            _currentEmployees.Remove(oldEmployee);
        }
        public void ListEmployees()
        {
            foreach (var employee in _currentEmployees)
            {
                Console.WriteLine($"{employee.EmployeeFirstName} {employee.EmployeeLastName} is the {employee.JobTitle} at {Name} since {employee.StartDate}");
            }
        }
        public Company(string companyName, DateTime date)
        {
            Name = companyName;
            CreatedOn = date;
        }
    }
}
