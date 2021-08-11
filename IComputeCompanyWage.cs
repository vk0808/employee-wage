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
    }
}
