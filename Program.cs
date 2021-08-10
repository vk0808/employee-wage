using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create new instance of Employee class
            EmpWageBuilder cleanEarth = new EmpWageBuilder("CLeanEarth", 1000, 100, 20);
            EmpWageBuilder dMart = new EmpWageBuilder("DMart", 800, 90, 24);


            /// Displaying welcome message
            cleanEarth.welcome();
            /// Calculate employee wage
            cleanEarth.CalculateWage();
            /// Displaying results of the calculation
            cleanEarth.displayMsg();


            
            /// Calculate employee wage
            dMart.CalculateWage();
            /// Displaying results of the calculation
            dMart.displayMsg();
        }
    }
}