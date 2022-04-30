using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInheritance
{

    class Animal
    {
        public int age = 12;
        public void eating()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog:Animal
    {
        public string name = "Dog";
        public void walk()
        {
            Console.WriteLine("Walking...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.walk();
            dog.eating();
        }
    }
}
