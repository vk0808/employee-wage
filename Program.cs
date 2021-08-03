using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            /// Variables
            /// int IS_PART_TIME = 1;
            /// int IS_FULL_TIME = 2;
            int WAGE_PER_HR = 1000;
            int MAX_WORK_DAYS = 20;
            int totalWorkHr = 0;
            int hoursWorked;
            int wage = 0;

            for (int day = 1; day <= MAX_WORK_DAYS; day++)
            {

                Random rand = new Random();
                int empCheck = rand.Next(0, 3);

                switch (empCheck)
                {
                    case 1:
                        hoursWorked = 4;
                        break;

                    case 2:
                        hoursWorked = 8;
                        break;

                    default:
                        hoursWorked = 0;
                        break;
                }
                /// Calculate total working hour
                totalWorkHr = totalWorkHr + hoursWorked;

                /// Calculate total wage
                wage = (WAGE_PER_HR * hoursWorked) + wage;
            }
            Console.WriteLine("Total Working Hours is " + totalWorkHr);
            Console.WriteLine("Total Wage is " + wage);
        }
    }
}
