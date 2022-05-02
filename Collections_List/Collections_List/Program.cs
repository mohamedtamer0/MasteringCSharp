using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Mohamed");
            names.Add("Tamer");
            names.Add("Osama");
            names.Add("Ahmed");
            foreach(var x in names)
            {
                Console.WriteLine("named: " + x);
            }

            var ages = new List<int>() { 25, 30, 33, 40, 45 };
            foreach(var x in ages)
            {
                Console.WriteLine("ages: " + x);
            }

        }
    }
}
