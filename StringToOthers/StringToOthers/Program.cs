using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string age = "25";
            string salary = "1200.99ssd";

            int myAge = int.Parse(age);
            double mySalary;

            if(double.TryParse(salary, out mySalary))
            {
                Console.WriteLine("MySalary " + mySalary);
            }else
            {
                Console.WriteLine("can not converted");
            }



            Console.WriteLine("age " + age.GetType());
            Console.WriteLine("myAge " + myAge.GetType());
            Console.WriteLine("--------------");
            Console.WriteLine("salary " + salary.GetType());


        }
    }
}
