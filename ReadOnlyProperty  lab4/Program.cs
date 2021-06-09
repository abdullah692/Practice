using System;

namespace ReadOnlyProperty__lab4
{
    class Program
    {
        class Student

        {
            private string name;
            private int age;
           
            //creating the property field for readonly i.e get accessor
            public string Name
            {
                get
                {
                    return name;
                }
            }
            //creating the property field for readonly i.e get accessor
            public int Age
            {
                get
                {
                    return age;
                }
            }
            public Student(string a, int b)
            {
                name = a;
                age = b;
            }
        }

        static void Main(string[] args)
        {
            Student objStudent = new Student("Abdullah Siddiqui", 20);
            //invoking the get accessor
            Console.WriteLine("The name of the student is: " + objStudent.Name);
            //invoking the get accessor
            Console.WriteLine("The age of the student is : " + objStudent.Age);
            Console.ReadLine();
        }
    }
}
