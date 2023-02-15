using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationoops
{
    public class UsingSwitch
    {
        public const int isFullTime = 1;
        public const int empRatePerHrs = 20;
        public const int isPartTime = 2;
        public void SwitchCase()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case isFullTime:
                    empHrs = 8;
                    break;
                case isPartTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;

            }

            empWage = empHrs * empRatePerHrs;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
