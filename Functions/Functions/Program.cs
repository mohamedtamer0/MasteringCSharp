using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            printName();

            Program program = new Program();
            program.printName2();
            program.printName3("Osama");
            Console.WriteLine(printName4("Ali"));
            Console.WriteLine(program.printName5("Essa"));
        }


        static void printName()
        {
            Console.WriteLine("Mohamed Tamer");
        }

        void printName2()
        {
            Console.WriteLine("Mohamed Tamer");
        }

        void printName3(string name)
        {
            Console.WriteLine("Hello : " + name);
        }

        static string printName4(string name)
        {
            return name;
        }

         string printName5(string name)
        {
            return name;
        }



    }
}
