using EmployeeWageComputationoops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationoops
{
    public class EmpWageBuiltArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<CompanyEmployeeWage> CompanyEmployeeWageList;
        private Dictionary<string, CompanyEmployeeWage> companyToEmpwageMap;


        public EmpWageBuiltArray()
        {
            this.CompanyEmployeeWageList = new LinkedList<CompanyEmployeeWage>();
            this.companyToEmpwageMap = new Dictionary<string, CompanyEmployeeWage>();
        }

        public void addCompanyEmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmployeeWage CompanyEmployeeWage = new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.CompanyEmployeeWageList.AddLast(CompanyEmployeeWage);
            this.companyToEmpwageMap.Add(company, CompanyEmployeeWage);
        }


        public void computeEmpwage()
        {
            foreach (CompanyEmployeeWage companyEmployeeWage in this.CompanyEmployeeWageList)
            {
                companyEmployeeWage.setTotal(this.computeEmpwage(companyEmployeeWage));
                Console.WriteLine(companyEmployeeWage.tostring());
            }
        }

        private int computeEmpwage(CompanyEmployeeWage CompanyEmployeeWage);

        public int getTotalwage(string company)
        {
            return this.companyToEmpwageMap[company].totalEmpWage;
        }
    }
}