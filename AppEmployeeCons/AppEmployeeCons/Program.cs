using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmployeeCons
{

    class Person
    {
        string name;
        int age;
        string city;

        public Person(string _name, int _age, string _city)
        {
            name = _name;
            age = _age;
            city = _city;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Your Name is : " + name + " age : " + age + " city : " + city);
        }

    }



    class Program
    {

        public Program()
        {
            Console.WriteLine("Hello From Constructor!");
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj2 = new Program();
            Person obj3 = new Person("Mohamed",25,"Giza");
            obj3.PrintInfo();
            Person obj4 = new Person("Osama",30,"cairo");
            obj4.PrintInfo();
        }
    }
}
