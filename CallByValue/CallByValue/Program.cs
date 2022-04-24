using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class Program
    {

        static void myData(int num)
        {
            num += num;
            Console.WriteLine("inside function: " + num);
        }


        static void Main(string[] args)
        {
            int originalNum = 20;
            Console.WriteLine("outside function : " + originalNum);
            myData(originalNum);
            Console.WriteLine("outside function : " + originalNum);
        }
    }
}
