using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string myColor = Console.ReadLine();

            switch(myColor)
            {
                case "red":
                    Console.WriteLine("red");
                    break;

                case "blue":
                    Console.WriteLine("blue");
                    break;

                case "orange":
                    Console.WriteLine("orange");
                    break;

                case "yellow":
                    Console.WriteLine("yellow");
                    break;

                default:
                    Console.WriteLine("no Color");
                    break;

            }
        }
    }
}
