using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Faizan";
            FTE.LastName = "Ali";
            FTE.EMail = "faizan@gmail.com";
            FTE.YearlySalary = 1000000;
            FTE.PrintFullName();
            
            Console.WriteLine();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Faizan";
            PTE.LastName = "Md";
            PTE.PrintFullName();

            Console.WriteLine();

            ClieldClassCunstructor CCC = new ClieldClassCunstructor();

            Console.WriteLine();

            //Single Inheritance
            Accountcreditinfo accountcreditinfo = new Accountcreditinfo();
            Console.WriteLine(accountcreditinfo.Credit());
            Console.WriteLine();
            Debitinfo debitinfo = new Debitinfo();
            Console.WriteLine(debitinfo.Debit());
            Console.WriteLine();

            //Hierarchical inheritance
            A a = new A();
            Console.WriteLine(a.Msg());

            B b = new B();
            Console.WriteLine(b.Info());

            C c = new C();
            Console.WriteLine(c.GetInfo());
            Console.WriteLine();

            //Multilevel inheritance
            Person person = new Person();
            Console.WriteLine(person.PersonDet());

            Bird bird = new Bird();
            Console.WriteLine(bird.BirdDet());

            Animal animal = new Animal();
            Console.WriteLine(animal.AnimalDet());
            Console.WriteLine();

            //Multiple inheritances using Interfaces


            ICar car = new ICar();
            Console.WriteLine(car.setImgs("a"));
            Console.WriteLine(car.getAmount(1));
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string EMail;

        public  void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    //Cunstructor Inheritance

    public class ParentClassCunstructor
    {
        public ParentClassCunstructor()
        {
            Console.WriteLine("ParentClass Cunstructor Called...");
        }

        public ParentClassCunstructor(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ClieldClassCunstructor : ParentClassCunstructor
    {
        public ClieldClassCunstructor():base("derived class controlling Parent Class")
        {
            Console.WriteLine("ChildClass Cunstructor Called...");
        }
    }

    //Single Inheritance

    public class Accountcreditinfo
    {
        public string Credit()
        {
            return "balance is credited";
        }
    }

    public class Debitinfo: Accountcreditinfo
    {
        public string Debit()
        {
            return "balance is debit";
        }
    }

    //Hierarchical inheritance

    public class A
    {
        public string Msg()
        {
            return "This is A class Method...";
        }
    }
    public class B : A
    {
        public string Info()
        {
            Msg();
            return "This is B class Method...";
        }
    }
    public class C : A
    {
        public string GetInfo()
        {
            Msg();
            return "This is C class Method...";
        }
    }

    //Multilevel inheritance
    public class Person
    {
        public string PersonDet()
        {
            return "this is the person class";
        }
    }
    public class Bird : Person
    {
        public string BirdDet()
        {
            return "this is the Bird class";
        }
    }
    public class Animal : Bird
    {
        public string AnimalDet()
        {
            return "this is the Animal class";
        }
    }

    //Multiple inheritances using Interfaces

    public interface IA
    {
        string setImgs(string a);
    }
    public interface IB
    {
        int getAmount(int amount);
    }
    public class ICar : IA, IB  //Implementation
    {
        public int getAmount(int amt)
        {
            return 1000000;
        }
        public string setImgs(string a)
        {
            return "This is a Car";
        }
    }
}
