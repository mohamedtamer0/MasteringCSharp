using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("-------------------");

            //int count = 0;
            //string fullName = "Mohamed Tamer Mohamed";
            //while(count < fullName.Length)
            //{
            //    Console.WriteLine(fullName[count]);
            //    count++;
            //}


            int count = 0;
            string fullName = "Mohamed Tamer Mohamed";
            do
            {
                Console.WriteLine(fullName[count]);
                count++;
            } while (count < fullName.Length);



        }
    }
}
