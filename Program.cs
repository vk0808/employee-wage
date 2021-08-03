using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            /// Variables
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int WAGE_PER_HR = 1000;
            int hoursWorked;
            int dailyWage;

            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present Full-time");
                hoursWorked = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Present Part-time");
                hoursWorked = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                hoursWorked = 0;
            }
            dailyWage = WAGE_PER_HR * hoursWorked;
            Console.WriteLine("Total Wage is " + dailyWage);
        }
    }
}
