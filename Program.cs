using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employees__Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and User input
            Console.WriteLine("Enter the name of first Employee:");
            string e1Name = Console.ReadLine();
            Console.WriteLine("Salary:");
            int e1Salary = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the name of second Employee:");
            string e2Name = Console.ReadLine();
            Console.WriteLine("Salary:");
            int e2Salary = Convert.ToInt16(Console.ReadLine());

            //Info display
            Console.WriteLine("|-----------------------|--------------------------------|");
            Console.WriteLine("|Employee Name\t\t|\t\t  Employee Salary|");
            Console.WriteLine("|-----------------------|--------------------------------|");
            Console.WriteLine("|{0}\t\t\t|\t\t\t{1:C}|", e1Name, e1Salary);
            Console.WriteLine("|{0}\t\t\t|\t\t\t{1:C}|", e2Name, e2Salary);
            Console.WriteLine("|-----------------------|--------------------------------|");

        }
    }
}
