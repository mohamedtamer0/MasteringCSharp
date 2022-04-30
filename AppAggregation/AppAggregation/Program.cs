using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAggregation
{

    class Address
    {
        public string streetName;
        public string city;
        public int streetNo;
        public string email;

        public Address(string streetName,
         string city,
         int streetNo,
         string email)
        {
            this.streetName = streetName;
            this.city = city;
            this.streetNo = streetNo;
            this.email = email;
        }

    }

    class Student
    {
        public string name;
        public int age;
        public string country;
        public Address address;

        public Student(string name, int age, string country, Address address)
        {
            this.name = name;
            this.age = age;
            this.country = country;
            this.address = address;
        }

        public void PrintInfo()
        {
            Console.WriteLine("name: " + name + " - " + "age: " + age + " - " +
                "country: " + country + " - " + "city: " + address.city + " - " +
                "streetName: " + address.streetName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address add1 = new Address("tagEldawal","Imbaba",5,"mohamedtamerdev@gmail.com");
            Student stu = new Student("Mohamed", 25, "Egypt", add1);
            stu.PrintInfo();

        }
    }
}
