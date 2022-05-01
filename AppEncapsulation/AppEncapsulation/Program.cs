using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEncapsulation
{

    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public float salary { get; set; }
        public string department { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Mohamed Tamer";
            emp.age = 25;
            emp.salary = 2000.995f;
            emp.department = "Android Developer";

            Console.WriteLine("name: " + emp.name);
            Console.WriteLine("age: " + emp.age);
            Console.WriteLine("salary: " + emp.salary);
            Console.WriteLine("department: " + emp.department);

        }
    }
}
