using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Manager accountingVP = new Manager();
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            BaseEmployee emp = new Employee();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            //emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);
            //emp.FireSomeone();

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
