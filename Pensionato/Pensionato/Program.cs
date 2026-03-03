using System;
using System.Globalization;

namespace BoardingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Rents[] vect = new Rents[10];
           

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (j + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int rent = int.Parse(Console.ReadLine());
                vect[rent] = new Rents (name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
