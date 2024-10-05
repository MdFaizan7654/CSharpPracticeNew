using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FName = "Faizan";
        public string LName = "Ali";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName + " - Part Time Employee");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FName + " " + LName + " - Full Time Employee");
        }
    }
    public class TemporaryEmployee : Employee
    {
        //public override void PrintFullName()
        //{
        //    Console.WriteLine(FName + " " + LName + " - Temporary Employee");
        //}
    }
}
