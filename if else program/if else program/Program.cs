using System;

namespace if_else_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =5;
            if(num>5 )
            {
                Console.WriteLine("The number is greater");
            }
            else if (num<5 )
            {
                Console.WriteLine("The number is smaller");
            }
            else
            {
                Console.WriteLine("The number is equal");
            }
        }
    }
}
