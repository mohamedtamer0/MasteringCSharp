using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            double salary = 1200.99;
            float height = 3000.5F;
            byte mybyte = 255;

            Console.WriteLine("your age is : " + age.GetType());
            Console.WriteLine("your salary is : " + salary.GetType());
            Console.WriteLine("your height is : " + height.GetType());
            Console.WriteLine("your mybyte is : " + mybyte.GetType());


        }
    }
}
