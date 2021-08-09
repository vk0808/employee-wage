using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    public class Employee
    {
        private int wagePerHr;
        private int maxWorkHrs;
        private int maxWorkDays;
        private string company = null;

        const int FULL_TIME = 2; 
        const int HALF_TIME = 1;
        private int FULL_TIME_HR = 8; //full time hour
        private int HALF_TIME_HR = 4; // part-time hour
        private int ABSENT = 0; // absent hour

        private int totalWorkHr = 0;
        private int day = 1;
        private int wage = 0;


        public Employee(string company, int wagePerHr, int maxWorkHrs, int maxWorkDays)
        {
            this.wagePerHr = wagePerHr;
            this.maxWorkHrs = maxWorkHrs;
            this.maxWorkDays = maxWorkDays;
            this.company = company;
        }

        /// Method to display welcome message
        public string welcome()
        {
            return "Welcome to Employee Wage Computation";
        }

        /// Method to calculate wage
        public void CalculateWage()
        {
            while (day < this.maxWorkDays && totalWorkHr < this.maxWorkHrs)
            {
                Random rand = new Random();
                
                /// Determine if the employee is half/full/absent using random object 
                int empCheck = rand.Next(0, 3);

                /// Determine hours worked based on half/full/absent using switch and store it in hoursWorked
                var hoursWorked = empCheck switch
                {
                    HALF_TIME => HALF_TIME_HR,
                    FULL_TIME => FULL_TIME_HR,
                    _ => ABSENT,
                };

                /// Calculate total working hour
                totalWorkHr += hoursWorked;

                /// Calculate total wage
                wage = (this.wagePerHr * hoursWorked) + wage;

                /// Increment day
                day++;
            }
        }

        /// Method to get days
        public int GetDays()
        {
            return day;
        }

        /// Method to get hours
        public int GetHrs()
        {
            return totalWorkHr;
        }

        /// Method to get wage
        public int GetWage()
        {
            return wage;
        }

        /// Method to get company name
        public string GetCompany()
        {
            return company;
        }

        /// Method to display message
        public void displayMsg()
        {
            Console.WriteLine($"Company: {GetCompany()}");
            Console.WriteLine($"Total Working Hours: {GetHrs()}");
            Console.WriteLine($"No of Working days: {GetDays()}");
            Console.WriteLine($"Total Wage: {GetWage()}");
        }
    }
}
