using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAbstraction
{

   abstract class Person
    {
        public abstract void name();
    }

    class Student : Person
    {
        public override void name()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person per;
            per = new Student();
            per.name();
        }
    }
}
