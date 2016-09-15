// Alyssa Strand (Mahler)
// First In Class Program CIS 237

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import System.IO to use streamreader, etc
using System.IO;

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

            // Use the CSVProcessor method to load the employee information from the CSV file:
            ImportCSV("employees.csv", employees);

            // Create a variable of type UserInterface:
            UserInterface ui = new UserInterface();

            /// NEW - How to call a static class method:
            StaticUserInterface.GetUserInput();

            // Get the user input and assign to variable choice:
            //int choice = ui.GetUserInput();
            // Can use static class instead:
            int choice = StaticUserInterface.GetUserInput();

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

        // Method to import the CSV file:
        static bool ImportCSV(string pathToCsvFile, Employee[] employees)
        {
            // Create StreamReader object and set to null:
            StreamReader streamReader = null;   // Convention to use the same name (as opposed to inputFile, etc).

            // try/catch structure to read the file in:
            try
            {
                // Declare string variable line to store each line:
                string line;
                // Instantiate StreamReader object:
                streamReader = new StreamReader(pathToCsvFile);
                // Set counter to 0:
                int counter = 0;
                // Loop to process the line:
                while ((line = streamReader.ReadLine()) != null) // Assign and test for != null.
                {
                    // Call the process line method and send over the read in line, employees array, and index (incrementing):
                    processLine(line, employees, counter++);
                }
                // If successful, return true:
                return true;
            }
            // If try failed:
            catch (Exception ex)
            {
                // Error message display to user, including exception message and stack call:
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);   // Shows call order prior to error.
                // If catch is called, return false:
                return false;
            }
            finally /// NEW - executed regardless of whether catch is called!
            {
                if (streamReader != null)
                {   // Close the streamReader object:
                    streamReader.Close();
                }
            }
        }

        // Method to process the lines in the CSV file:
        static void processLine(string line, Employee[] employees, int index)
        {
            // Declare a string array and split it by commas:
            string[] parts = line.Split(',');
            // Read in the parts of parts and assign to variables:
            string firstName = parts[0];
            string lastName = parts[1];
            decimal weeklySalary = decimal.Parse(parts[2]);
            // Use the variables to instantiate a new Employee and assign it to the spot 
            // in the employees array of the index passed in.
            employees[index] = new Employee(firstName, lastName, weeklySalary);



        }

    }
}
