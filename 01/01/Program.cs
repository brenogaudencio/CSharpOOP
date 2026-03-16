using System;
using System.Globalization;
using _01;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2, 3);
            int s2 = Calculator.Sum(4, 5);
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }

    }
} 
