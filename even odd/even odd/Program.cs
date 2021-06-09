using System;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number is even or odd");
             num=Convert.ToInt32(Console.ReadLine());
            if(num %2 == 0)
            {
                Console.WriteLine("The number is even ");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            
        }
    }
}
