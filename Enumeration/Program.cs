using System;

namespace Enumeration
{
    enum weekdays
    {
        MON, TUES, WED, THURS, FRI, SAT, SUN
    }

    public class Program
    {
        static void Main(string[] args)
        {
            weekdays i;

            for (i = weekdays.MON; i <= weekdays.SUN; i++)
            {
                Console.WriteLine((int)i);
            }
        }
    }
}


