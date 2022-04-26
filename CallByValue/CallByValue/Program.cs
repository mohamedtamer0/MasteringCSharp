using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class Program
    {

        static int myAge = 25; // Global....


        static void Main(string[] args)
        {
            //int originalNum = 20;
            //Console.WriteLine("outside function : " + originalNum);
            //myData(ref originalNum);
            //Console.WriteLine("outside function : " + originalNum);

            Console.WriteLine("inside Main function : " + myAge);


            int originalNum = 20;
            Console.WriteLine("outside function : " + originalNum);
            myResult(out originalNum);
            Console.WriteLine("outside function : " + originalNum);


            myData2();
        }



        static void myData(ref int num)
        {
            num += num;
            Console.WriteLine("inside function: " + num);
        }

        static void myResult(out int num)
        {
            int num2 = 10;
            num = num2;
            num *= num;
            //Console.WriteLine("inside function: " + num);
        }


        static void myData2()
        {
            int mynum = 10;
            Console.WriteLine("inside myData2 function: " + mynum);
        }


    }
}
