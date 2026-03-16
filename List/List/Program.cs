using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Marco");
            list.Insert(2, "Breno");// Cada lista comeca no 0


            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int s3 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + s3);

            int s4 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + s4);

            Console.WriteLine("==========================");

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Breno");

            Console.WriteLine("==========================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("==========================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("==========================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
