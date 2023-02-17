using EmployeeWageComputationoops;
using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            MultipleWage e1 = new MultipleWage();
            int a = e1.EmployeeWage("BridgeLabz", 20, 20, 100);
            Console.WriteLine("First Company :" + a);

            MultipleWage e2 = new MultipleWage();
            int b = e1.EmployeeWage("AkadBakad", 20, 20, 100);
            Console.WriteLine("Second Company : " + b);
        }
    }
}