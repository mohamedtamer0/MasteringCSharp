using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Mohamed");
            names.AddLast("Tamer");
            names.AddLast("Ahmed");
            names.AddLast("Osama");
            names.AddFirst("Ali");

            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }

            Console.WriteLine("-------------------");
            LinkedListNode<string> secondNames = names.Find("Osama");
            names.AddBefore(secondNames, "Khalid");
            names.AddAfter(secondNames, "Waleed");

            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }
        }
    }
}
