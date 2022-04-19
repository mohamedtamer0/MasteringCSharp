using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            String str = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str);
        }
    }
}