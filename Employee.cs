﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    public class EmpWageBuilderArray
    {
      
        const int FULL_TIME = 2; 
        const int HALF_TIME = 1;
        private int FULL_TIME_HR = 8; //full time hour
        private int HALF_TIME_HR = 4; // part-time hour
        private int ABSENT = 0; // absent hour


        private int noOfCompanies = 0;
        private CompanyEmpWage[] companyEmpWageArray;

       public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }


        public void addCompanyWage(string company, int wagePerHr, int maxWorkDays, int maxWorkHrs)
        {
            companyEmpWageArray[this.noOfCompanies] = new CompanyEmpWage(company, wagePerHr, maxWorkDays, maxWorkHrs);
            noOfCompanies++;
        }

        public void computeCompanyWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                companyEmpWageArray[i].setEmpWage(this.CalculateWage(this.companyEmpWageArray[i]));
                this.companyEmpWageArray[i].displayMsg();
            }
        }


        /// Method to calculate wage
        private int CalculateWage(CompanyEmpWage companyEmpWage)
        {
            int totalWorkHr = 0, day = 1;

            while (day < companyEmpWage.maxWorkDays && totalWorkHr <= companyEmpWage.maxWorkHrs)
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

                Console.WriteLine($"Day#: {day}\nHrs: {hoursWorked}");

                /// Increment day
                day++;
            }
            
            /// Return total wage
            return totalWorkHr * companyEmpWage.wagePerHr;
        }


        /// Method to display welcome message
        public void welcome()
        {
            Console.WriteLine("Welcome to Employee Wage Computation\n");
        }
    }
}
