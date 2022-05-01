using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mohamed;
namespace Mohamed
{
    class Person
    {
        public string fullName = "Mohamed Tamer";
        protected int age = 25;

        public void PrintInfo()
        {
            Console.WriteLine("Hello " + fullName + "age " + age);
        }
    }
}


namespace AppAccessModifier
{

    class Student
    {
        public string fullName = "Mohamed Tamer";
        protected int age = 25;

        public void PrintInfo()
        {
            Console.WriteLine("Hello " + fullName + "age " + age);
        }

        protected void PrintAge()
        {
            Console.WriteLine("age " + age);
        }
    }



    class Program:Student
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.PrintInfo();

            Program stu = new Program();
            //stu.PrintAge(); //protected
            stu.PrintAge();
        }
    }
}
