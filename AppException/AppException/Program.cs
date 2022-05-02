using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 50;
                int num2 = 0;
                int sum = num1 / num2;
                Console.WriteLine("Result: " + sum);
            }
            catch(Exception e)
            {
                Console.WriteLine("catch: " + e);
            }
            finally
            {
                Console.WriteLine("finally can run");
            }
            Console.WriteLine("Hello World");

        }
    }
}
