using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPloymorphisim
{

    class Person
    {
        public string name = "Person";
        public virtual void run()
        {
            Console.WriteLine("running.........");
        }
    }

    class Student:Person
    {
        public string name = "Mohamed";
        public override void run()
        {
            Console.WriteLine("Student running.........");
        }
    }

    class Employee : Person
    {
        public override void run()
        {
            Console.WriteLine("Employee running.........");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Person per;

            per = new Student();
            per.run();
            Console.WriteLine("Student name : " + per.name);

            per = new Employee();
            per.run();
        }
    }
}
