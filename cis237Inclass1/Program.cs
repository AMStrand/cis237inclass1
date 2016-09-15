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
            // Create a variable of type Employee called myEmployee:
            Employee myEmployee = new Employee();

            // Assign values to the properties of myEmployee:
            myEmployee.FirstName = "Alyssa";
            myEmployee.LastName = "Strand";
            myEmployee.WeeklySalary = 2000.00m;

            // Display values:
            Console.WriteLine(myEmployee.FirstName);
            Console.WriteLine(myEmployee);

            // Create and populate an array of Employee objects:
            Employee[] employees = new Employee[10];
            employees[0] = new Employee("James", "Kirk", 453m);
            employees[1] = new Employee("Jessica", "Holmes", 700m);
            employees[2] = new Employee("Alan", "Jones", 1000m);
            employees[3] = new Employee("Tara", "Richards", 800m);
            employees[4] = new Employee("Ella", "Fitzgerald", 520m);

            foreach (Employee employee in employees)
            {   // Loop to display the employee's name and yearly salary for each employee....
                if (employee != null)   // As long as the employee in the array is not null (5-9)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                }
            }

            // Create a variable of type UserInterface:
            UserInterface ui = new UserInterface();
            // Get the user input and assign to variable choice:
            int choice = ui.GetUserInput();
            while (choice != 2) // If choice is not 2 (to exit), loop:
            {
                if (choice == 1)
                {   // If choice is to output the info, clear allOutput before adding more information:
                    string allOutput = "";
                    // Loop to add each employee's information as a line to the string allOutput...
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)   // As long as the employee isn't null.
                        {
                            // Concatenate the employee's name and yearly salary and add to allOutput:
                            allOutput += employee.ToString() + " " + employee.YearlySalary() + Environment.NewLine;
                        }
                    }
                    // Output allOutput to user:
                    ui.PrintAllOutput(allOutput);
                }
                // Get user input again:
                choice = ui.GetUserInput(); 
            }

        }
    }
}
