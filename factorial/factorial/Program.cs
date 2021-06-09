using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num;
           int fat;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num==0 || num==1)
            {
                fat = 1;
            }
            else 
            {
                for (int i = 1; i <= num; i++) 
                {
                   fat = fat * i;
                }
                Console.WriteLine(fat);
            }
           
        }
    }
}
