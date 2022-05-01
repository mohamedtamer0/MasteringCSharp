using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{

    interface Person
    {
        void fullName();
    }

    interface Person2
    {
        void age();
    }

    class Student : Person, Person2
    {
        public void fullName()
        {
            Console.WriteLine("Hello Student");
        }

        public void age()
        {
            Console.WriteLine("Student age");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person per;
            Student stu = new Student();
            stu.fullName();
            stu.age();
            
        }
    }
}
