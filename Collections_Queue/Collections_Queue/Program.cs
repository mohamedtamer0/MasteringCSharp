using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();
            names.Enqueue("Mohamed");
            names.Enqueue("Tamer");
            names.Enqueue("Ahmed");
            names.Enqueue("Osama");

            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }

            Console.WriteLine("--------------");
            Console.WriteLine("peek method: " + names.Peek());
            Console.WriteLine("Dequeue method: " + names.Dequeue());
            Console.WriteLine("--------------");
            foreach (var x in names)
            {
                Console.WriteLine("names :" + x);
            }
        }
    }
}
