using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    public class Employee
    {
        int WAGE_PER_HR;
        int MAX_WORK_HRS;
        int MAX_WORK_DAYS;

        int FULL_TIME_HR = 8;
        int HALF_TIME_HR = 4;
        int ABSENT = 0;

        int totalWorkHr = 0;
        int day = 1;
        int wage = 0;


        public Employee(int wagePerHr, int maxWorkHrs, int maxWorkDays)
        {
            this.WAGE_PER_HR = wagePerHr;
            this.MAX_WORK_HRS = maxWorkHrs;
            this.MAX_WORK_DAYS = maxWorkDays;
        }

        public string Greet()
        {
            return "Welcome to Employee Wage Computation";
        }

        public void CalculateWage()
        {
            while (day < this.MAX_WORK_DAYS && totalWorkHr < this.MAX_WORK_HRS)
            {
                Random rand = new Random();
                
                /// Determine if the employee is half/full/absent using random object 
                int empCheck = rand.Next(0, 3);

                /// Determine hours worked based on half/full/absent using switch and store it in hoursWorked
                var hoursWorked = empCheck switch
                {
                    1 => HALF_TIME_HR,
                    2 => FULL_TIME_HR,
                    _ => ABSENT,
                };

                /// Calculate total working hour
                totalWorkHr += hoursWorked;

                /// Calculate total wage
                wage = (this.WAGE_PER_HR * hoursWorked) + wage;

                /// Increment day
                day++;
            }
        }

        public int GetDays()
        {
            return day;
        }

        public int GetHrs()
        {
            return totalWorkHr;
        }

        public int GetWage()
        {
            return wage;
        }
    }
}
