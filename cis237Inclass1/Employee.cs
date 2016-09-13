// Class to hold Employee information: FirstName, LastName, and WeeklySalary.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Employee
    {
        // Backing Fields:
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        // Properties:
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // Methods:
        public override string ToString()   
        // Overrides the implicit ToString to assign a particular set of values to the class name:
        {
            return this._firstName + " " + this.LastName;
        }

        public decimal YearlySalary()
        {
            return this.WeeklySalary * 52;
        }

        // Constructor(s):
        public Employee()
        {
            // Default constructor.
        }

        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._weeklySalary = weeklySalary;


        }





    }
}
