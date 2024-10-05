using System;

namespace ClassLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Faizan", "Ali");
            c.PrintFullName();
            

            Emp e = new Emp(1, "Faizan", "faizan@mail.com");
            e.GetEmp();

            Console.WriteLine();

            //Static and Instance Class
            Cirle c1 = new Cirle(5);
            float result = c1.CalculateAre();
            Console.WriteLine($"Circle of Area = {result}");
            Console.ReadLine();
        }
    }

    public class Customer
    {
        string fName;
        string lName;

        public Customer(string FName, string LName)
        {
            fName = FName;
            lName = LName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full name = {fName} {lName}");
        }
    }

    public class Emp
    {
        int id;
        string name;
        string eMail;

        public Emp(int id, string name, string eMail)
        {
            this.id = id;
            this.name = name;
            this.eMail = eMail;
        }

        public void GetEmp()
        {
            Console.WriteLine($"Get Emp = {id} {name} {eMail}");
        }
    }
    
    //Static and Instance Class 

    public class Cirle
    {
        float _PI = 3.141F;
        int _Radious;

        public Cirle(int radious)
        {
            this._Radious = radious;
        }

        public float CalculateAre()
        {
            return this._PI * this._Radious*this._Radious;
        }
    } 
    
}
