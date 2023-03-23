using System;
using System.Collections;

namespace Generic_Demo
{
    public class Program

    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the first value");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second value");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third value");
            int num3=Convert.ToInt32(Console.ReadLine());
            int val = Gmax <int>.MaximumNumber(num1, num2, num3);
            Console.WriteLine("{0}is Greater", val);
        }
    }
}
