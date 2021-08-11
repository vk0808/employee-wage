using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IComputeCompanyWage
    {
        public void addCompanyWage(string company, int wagePerHr, int maxWorkDays, int maxWorkHrs);
        public void computeCompanyWage();
        public void welcome();
        public string getCompany();
        public bool checkCompany(string qeury);
        public void companyQuery();
        public int getTotalWage(string company);
    }
}
