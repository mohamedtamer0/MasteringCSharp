using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Mohamed");
            names.Add("Tamer");
            names.Add("Osama");
            foreach(var x in names)
            {
                Console.WriteLine("names: " + x);
            }


            var ages = new HashSet<int>() { 25,30,33,40};
            foreach (var x in ages)
            {
                Console.WriteLine("ages: " + x);
            }

        }
    }
}
