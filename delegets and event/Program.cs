using System;

namespace delegets_and_event
{
    class Program
    {
        public delegate void MyDelegate(int a);

        public class DelgetsNevents
        {
            public event MyDelegate MyEvent;

            public void RaiseEvent()
            {
                MyEvent(20);
                Console.WriteLine("Event Raised , I study in NED University ");
            }

            public void Display(int x)
            {
                Console.WriteLine("Display Method {0}", x);
            }
        }

        static void Main(string[] args)
        {

            DelgetsNevents obj = new DelgetsNevents();
            obj.MyEvent += new MyDelegate(obj.Display);

            obj.RaiseEvent();
            Console.ReadLine();
        }

    }
}
