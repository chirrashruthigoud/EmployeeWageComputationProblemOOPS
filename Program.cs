using EmployeeWageComputationoops;
using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWageint dMart = new EmployeeWageint("DMart", 20, 2, 10);
            EmployeeWageint reliance = new EmployeeWageint("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}