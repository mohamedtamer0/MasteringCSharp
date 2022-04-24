using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("your Name is: " + firstName);
        }
    }
}
