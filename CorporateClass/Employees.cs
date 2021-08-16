using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass
{
    class Employees
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public Employees(string firstName, string lastName, string job, DateTime startDay)
        {
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            JobTitle = job;
            StartDate = startDay;
        }

    }
}
