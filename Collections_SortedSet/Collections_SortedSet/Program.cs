using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("Mohamed");
            names.Add("Tamer");
            names.Add("Ahmed");
            names.Add("Osama");

            foreach(var x in names)
            {
                Console.WriteLine("names :" + x);
            }

            var ages = new SortedSet<int>() { 40, 55, 20, 15, 3, 53 };

            foreach (var x in ages)
            {
                Console.WriteLine("ages :" + x);
            }

        }
    }
}
