using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamer;

namespace Mohamed
{
    class Person
    {
        public void PrintInfo()
        {
            Console.WriteLine("nameSpace Mohamed!");
        }
    }
}

namespace Tamer
{
    class Person2
    {
        public void PrintInfo()
        {
            Console.WriteLine("nameSpace Tamer!");
        }
    }
}


namespace AppNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Mohamed.Person mper = new Mohamed.Person();
            mper.PrintInfo();

            Person2 tper = new Person2();
            tper.PrintInfo();
        }
    }
}
