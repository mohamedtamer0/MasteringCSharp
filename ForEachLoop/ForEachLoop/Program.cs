using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] obj = {"mohamed","tamer","osama","ali"};

            foreach(var x in obj)
            {
                //if(x == "osama")
                //{
                //    break;
                //}

                if (x == "osama")
                {
                    continue;
                }
                Console.WriteLine(x);
            }
        }
    }
}
