using EmployeeWageComputationoops;
using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            MultipleWageInterface dMart = new MultipleWageInterface("DMart", 20, 2, 10);
            MultipleWageInterface reliance = new MultipleWageInterface("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}