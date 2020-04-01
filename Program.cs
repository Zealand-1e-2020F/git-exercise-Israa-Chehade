using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass1 = new myClass("Israa", "Birthevej 34", 2740);
            myClass my1 = new myClass("Chehade", "Ingevej 3", 2730);
            myclass1.ToString();

            System.Console.WriteLine(myclass1.ToString());


        }
    }
}
