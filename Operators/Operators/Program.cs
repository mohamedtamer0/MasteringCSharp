using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 4;
            int sum = num1 + num2;

            Console.WriteLine("Add= " + sum);
            Console.WriteLine("Sub= " + (num1 - num2));
            Console.WriteLine("Multi= " + (num1 * num2));
            Console.WriteLine("Div= " + (num1 / num2));
            Console.WriteLine("Mod= " + (num1 & num2));
        }
    }
}
