using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++)
            {
                Console.WriteLine("Hello World!" + x);
            }

            string[] myColors = { "red", "white", "Blue", "Blcak" };
            for (int x = 0; x < myColors.Length; x++)
            {
                Console.WriteLine("Hello World!" + myColors[x]);
            }
        }
    }
}
