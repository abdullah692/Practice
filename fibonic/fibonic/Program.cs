using System;

namespace fibonic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c,n;
            Console.WriteLine("Fibonic series program");
            Console.WriteLine("Enter the range of the number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=a; i<=n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
               

            }


        }
    }
}
