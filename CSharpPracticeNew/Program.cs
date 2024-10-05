using System;

namespace CSharpPracticeNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Method
            Console.WriteLine("Static Method");
            Program.EvenNumber(30);
            Console.WriteLine();

            //Instance Method
            Console.WriteLine();
            Console.WriteLine("Instance Method");
            Program p = new Program();
            int sum = p.Add(1, 2);
            Console.WriteLine($"Sum = {sum}");

            // Method Parameters , Value and Reference Parameters
            Console.WriteLine();
            Console.WriteLine("Method Parameters , Value and Reference Parameters");
            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine(i);

            //Out Parameters
            Console.WriteLine();
            Console.WriteLine("Out Parameters");
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine($"sum = {Total} & product = {Product}");

            //Parameters Array 
            Console.WriteLine();
            Console.WriteLine("Parameters Array");
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            ParamsMethod(Numbers);
            //ParamsMethod(1,2,3,4);
            Console.ReadLine();
        }
        //Static Method
        public static void EvenNumber(int target)
        {
            int start = 0;
            while(start <= target)
            {
                Console.Write($"{start} ");
                start = start + 2;
            }
        }
        //Instance Method
        public int Add(int A ,int B)
        {
            return A + B;
        }

        // Method Parameters , Value and Reference Parameters

        public static void SimpleMethod(ref int j)
        {
            j = 150;
        }

        //Out Parameters

        public static void Calculate(int FN, int SN, out int Sum ,out int Product )
        {
            Sum = FN+SN;
            Product = FN*SN;
        }

        //Parameters Array 

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine($"There are {Numbers.Length} elements ");
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
