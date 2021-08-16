using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var spyCompany = new Company("Super Secret Spy Agency", new DateTime(1969, 8, 21));

            var austin = new Employees("Austin", "Powers", "Manager", DateTime.Now);
            var james = new Employees("James", "Bond", "Assistant Manager", DateTime.Now);
            var archer = new Employees("Sterling", "Archer", "Apprentice", DateTime.Now);

            spyCompany.AddEmployee(austin);
            spyCompany.AddEmployee(james);
            spyCompany.AddEmployee(archer);
            spyCompany.ListEmployees();

            Console.WriteLine();

            var sportsCompany = new Company("Sports R Us", new DateTime(1962, 6, 15));

            var ben = new Employees("Ben", "Rodriguez", "Manager", DateTime.Now);
            sportsCompany.AddEmployee(ben);

            var ham = new Employees("Ham", "Porter", "Motivator", DateTime.Now);
            sportsCompany.AddEmployee(ham);

            var yeah = new Employees("Yeah-Yeah", "McClennan", "Yes Man", DateTime.Now);
            sportsCompany.AddEmployee(yeah);

            var squints = new Employees("Squints", "Palledorous", "Lifeguard", DateTime.Now);
            sportsCompany.AddEmployee(squints);

            var smalls = new Employees("Scotty", "Smalls", "New Guy", DateTime.Now);
            sportsCompany.AddEmployee(smalls);

            sportsCompany.ListEmployees();
            

        }
    }
}
