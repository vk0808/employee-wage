using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            /// Variables
            int IS_PRESENT = 1;
            int WAGE_PER_HR = 1000;
            int hoursWorked = 8;
            int dailyWage = 0;

            Random rand = new Random();
            int empCheck = rand.Next(0, 2);

            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                dailyWage = WAGE_PER_HR * hoursWorked;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total Wage is " + dailyWage);
        }
    }
}
