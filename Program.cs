﻿using EmployeeWageComputationoops;
using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            TotalEmpWage dMart = new TotalEmpWage("DMart", 20, 2, 10);
            TotalEmpWage reliance = new TotalEmpWage("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}