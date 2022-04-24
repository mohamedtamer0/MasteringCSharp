using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStateIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Somthing: ");
            string firstName = Console.ReadLine();

            if(firstName.Equals("Mohamed", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hello Mohamed");
            }else if(firstName.Equals("Tamer", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hello Tamer");
            }else
            {
                Console.WriteLine("Not Same");
            }
        }
    }
}
