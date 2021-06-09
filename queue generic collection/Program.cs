using System;
using System.Collections.Generic;

namespace queue_generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> uni = new Queue<string>();
            string name;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter the University name:");
                name = Convert.ToString(Console.ReadLine());
                uni.Enqueue(name);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Printiing the values of Queue");
            Console.WriteLine("\n");
            foreach (object obj in uni)
                Console.WriteLine(obj);
            Console.ReadLine();

        }
    }
}
