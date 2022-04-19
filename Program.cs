using System;

namespace MasteringCSharp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            String str1 = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str1);


            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';


            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello";


            //TODO: Declare an array of values
            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" };

            // TODO: Print the values using a Formatting string
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, c, b, str, f, d, x, z);

        }
    }
}