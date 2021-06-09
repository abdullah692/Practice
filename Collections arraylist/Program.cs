using System;
using System.Collections;
namespace Collections_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the arraylist 
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity); //shows the capacity in array ,we can enter 4 vales at a time
            //we can add values in arrayList with al.Add();
            al.Add(100); al.Add(200); al.Add(300); al.Add(400);

            Console.WriteLine(al.Capacity);
            //used to print the values
               foreach (object obj in al)
                Console.Write(obj + "  ");
            Console.Write("\n");
            //we can insert values 
            al.Insert(2, 340); 
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.RemoveAt(3);
            foreach (object obj in al)
                Console.Write(obj + " ");
        }
    }
}
