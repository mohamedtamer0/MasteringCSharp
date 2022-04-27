using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOOP
{

    public class Student
    {
        public string name;
        public int age;
        public double salary;


        public void AddData(string name1,int age1)
        {
            name = name1;
            age = age1;
        }
        public void PrintData()
        {
            Console.WriteLine(name + " " + " " + age);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.name = "Mohamed";
            stu.age = 25;
            stu.salary = 2000.45;
            Console.WriteLine(stu.name + " " + stu.age + " " + stu.salary);

            Console.WriteLine("------------------------------");

            Student stu2 = new Student();
            stu2.AddData("Mohamed", 25);
            stu2.PrintData();

            Student stu3 = new Student();
            stu3.AddData("Ali", 30);
            stu3.PrintData();

        }
    }
}
