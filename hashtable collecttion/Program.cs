using System;
using System.Collections;

namespace hashtable_collecttion
{
    class HashCollection
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //Adding the values in hashtable
            ht.Add("Eid",101);
            ht.Add("Ename", "Abdullah Siddiqui");
            ht.Add("Salary", 100000);
            ht.Add("Job", "Freelancer");
            ht.Add("Phone No", 03352116800);
            ht.Add("Location", "Karachi");

            //Printing the keys 
            foreach (object key in ht.Keys)
                Console.WriteLine(key);
            
            //Printing the values only 
            //We can also print the values as ht.Values is foreach loop 
            //and console.writeLine(key);
            foreach (object key in ht.Keys)
                Console.WriteLine(ht[key]);
            Console.ReadLine();
            //Printing the both keys and values
            foreach (object key in ht.Keys)
                Console.WriteLine(key + ": " + ht[key]);
            Console.ReadLine();
        }
    }
}
