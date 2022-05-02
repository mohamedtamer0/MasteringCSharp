using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChecked
{
    class Program
    {
        static void Main(string[] args)
        {

            //checked
            //{
            //    int num = int.MaxValue;
            //    int sum = num + 10;
            //    Console.WriteLine(sum);
            //}

            unchecked
            {
                int num = int.MaxValue;
                int sum = num + 10;
                Console.WriteLine(sum);
            }
        }
    }
}
