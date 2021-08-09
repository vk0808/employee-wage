using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create new instance of Employee class
            Employee employee = new Employee("CLeanEarth", 1000, 100, 20);


            /// Displaying welcome message
            Console.WriteLine(employee.welcome() + "\n");

            /// Calculate employee wage
            employee.CalculateWage();

            /// Displaying results of the calculation
            employee.displayMsg();
        }
    }
}