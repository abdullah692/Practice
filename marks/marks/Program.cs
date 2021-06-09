using System;

namespace marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 75;
            Console.WriteLine("Check the grade of student acc to the marks");
            if(marks>=80)
            {
                Console.WriteLine("U got A+ grade");
            }
            else if(marks>=70 || marks<=79)
            {
                Console.WriteLine("U got A grade");
            }
            else if(marks >=60 || marks<=69)
            {
                Console.WriteLine("U got B grade");
            }
            else if(marks>=50 || marks<=59)
            {
                Console.WriteLine("U got C grade");
            }
        }
    }
}
