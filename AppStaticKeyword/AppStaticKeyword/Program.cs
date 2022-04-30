using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStaticKeyword
{

    class Employee
    {
        public string name;
        public int age;
        public static string companyName = "CodeDev";

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("name : " + name + " age : " + age + " companyName : " + companyName);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Employee.companyName = "google";
            Employee e = new Employee("Mohamed",25);
            e.PrintInfo();
        }
    }
}
