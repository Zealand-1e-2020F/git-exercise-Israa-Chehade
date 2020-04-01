using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass2 myclass1 = new myClass2("Israa", "Birthevej 34", 2740, "Skovlunde");
            myClass2 my1 = new myClass2("Chehade", "Ingevej 3", 2730, "København");
            myclass1.ToString();

            System.Console.WriteLine(myclass1.ToString());


        }
    }
}
