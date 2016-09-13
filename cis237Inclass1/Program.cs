// Alyssa Strand (Mahler)
// First In Class Program CIS 237

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();

            myEmployee.FirstName = "Alyssa";
            myEmployee.LastName = "Strand";
            myEmployee.WeeklySalary = 2000.00m;

            Console.WriteLine(myEmployee.FirstName);
            Console.WriteLine(myEmployee);

            Employee[] employees = new Employee[10];

            employees[0] = new Employee("James", "Kirk", 453m);
            employees[1] = new Employee("Jessica", "Holmes", 700m);
            employees[2] = new Employee("Alan", "Jones", 1000m);
            employees[3] = new Employee("Tara", "Richards", 800m);
            employees[4] = new Employee("Ella", "Fitzgerald", 520m);

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                }
            }




        }
    }
}
