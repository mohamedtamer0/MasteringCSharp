﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{

    class Person
    {
        public string name;
        public int age;
        public string city;
        public string country;

        public Person(string name,
         int age,
         string city,
         string country)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
        }

        public void ShowInfo()
        {
            Console.WriteLine("name: " + name + " age : " + age + " city: " + city + " country:" + country);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Mohamed",25,"Giza","Egypt");
            p.ShowInfo();
        }
    }
}
