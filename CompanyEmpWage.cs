using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company = null;
        public int wagePerHr;
        public int maxWorkHrs;
        public int maxWorkDays;
        public int totalWage = 0;

        public CompanyEmpWage(string company, int wagePerHr, int maxWorkHrs, int maxWorkDays)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.maxWorkHrs = maxWorkHrs;
            this.maxWorkDays = maxWorkDays;
        }

        public void setEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        /// Method to display message
        public void displayMsg()
        {
            Console.WriteLine($"Company: {this.company}\nTotal Wage: {this.totalWage}\n");
        }
    }
}
