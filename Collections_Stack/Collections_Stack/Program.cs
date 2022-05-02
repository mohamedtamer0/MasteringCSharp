using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Stack<string>();
            names.Push("Mohamed");
            names.Push("Tamer");
            names.Push("Ahmed");
            names.Push("Osama");

            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("peek method: " + names.Peek());
            Console.WriteLine("pop method: " + names.Pop());
            Console.WriteLine("--------------");
            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }

        }
    }
}
