using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Dictionary<string, string>();
            names.Add("1","Mohamed");
            names.Add("2", "Tamer");
            names.Add("3", "Ahmed");
            names.Add("4", "Osama");
            names.Add("5", "Ali");

            foreach (KeyValuePair<string,string> x in names)
            {
                Console.WriteLine("Key :" + x.Key + " " + "Value: " + x.Value);
            }

            /*
             * Sorted - Dictionary
             */

            Console.WriteLine("-------------------");

            var names2 = new SortedDictionary<int, string>();
            names2.Add(2, "Mohamed");
            names2.Add(3, "Tamer");
            names2.Add(5, "Ahmed");
            names2.Add(1, "Osama");
            names2.Add(4, "Ali");

            foreach (KeyValuePair<int, string> x in names2)
            {
                Console.WriteLine("Key :" + x.Key + " " + "Value: " + x.Value);
            }
        }
    }
}
