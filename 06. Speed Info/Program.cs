using System;

namespace _06._Speed_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            if (num1 <= 10)
                Console.WriteLine("slow");
            else if (num1 > 10 && num1 <= 50)
                Console.WriteLine("average");
            else if (num1 > 50 && num1 <= 150)
                Console.WriteLine("fast");
            else if (num1 > 150 && num1 <= 1000)
                Console.WriteLine("ultra fast");
            
            else
                Console.WriteLine("extremely fast");
        }
    }
}
