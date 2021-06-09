using System;

namespace Exception_handler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("ENter the firdt number: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int b = int.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine("The result is: " + z);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
           finally
            {
                Console.WriteLine("The program is executed: ");
            }
        }
    }
}
