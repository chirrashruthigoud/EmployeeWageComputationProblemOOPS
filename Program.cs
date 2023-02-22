using EmployeeWageComputationoops;

namespace EmployeeWageComputationoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageBuiltArray empWageBuiltArray = new EmpWageBuiltArray();
            empWageBuiltArray.addCompanyEmployeeWage("DMart", 20, 2, 10);
            empWageBuiltArray.addCompanyEmployeeWage("Reliance", 10, 4, 20);
            empWageBuiltArray.computeEmpwage();
            Console.WriteLine(" Total wage for DMart company: " + empWageBuiltArray.getTotalwage("DMart"));
        }
    }
}