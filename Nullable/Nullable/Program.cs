using System;

namespace Nullable{
    class Program{
        static void Main(string[] args){
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine("=================================================");

            double a = x ?? 5.0;
            double b = y ?? 5.0;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

}