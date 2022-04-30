using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOverriding
{

    class Person
    {
        public virtual void eating()
        {
            Console.WriteLine("eating...!");
        }
    }


    class Student:Person
    {
        public override void eating()
        {
            Console.WriteLine("Student is eating...!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student stu = new Student();
            stu.eating();
        }
    }
}
