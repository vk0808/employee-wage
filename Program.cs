using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Create new instance of Employee class
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            /// Displaying welcome message
            empWageBuilder.welcome();

            empWageBuilder.addCompanyWage("CleanEarth", 1000, 100, 20);
            empWageBuilder.addCompanyWage("DMart", 800, 90, 24);

            empWageBuilder.computeCompanyWage();
        }
    }
}