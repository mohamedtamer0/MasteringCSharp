using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new SortedList<string, string>();
            names.Add("3", "Mohamed");
            names.Add("5", "Tamer");
            names.Add("2", "Ahmed");
            names.Add("4", "Osama");
            names.Add("1", "Ali");

            foreach (KeyValuePair<string, string> x in names)
            {
                Console.WriteLine("Key :" + x.Key + " " + "Value: " + x.Value);
            }
        }
    }
}
