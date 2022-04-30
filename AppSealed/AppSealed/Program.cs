using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSealed
{

    sealed class Person
    {
        public void walk()
        {
            Console.WriteLine("walk!");
        }
    }

    class Student :Person
    {
        public void smile()
        {
            Console.WriteLine("smile!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.smile();
            obj.walk();
        }
    }
}
