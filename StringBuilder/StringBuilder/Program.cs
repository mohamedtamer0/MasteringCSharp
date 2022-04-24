using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mohamed";
            string secondName = "Tamer";

            StringBuilder sb = new StringBuilder();

            sb.Append("Mohamed");
            sb.Append(" Tamer");


            Console.WriteLine(sb.ToString());
        }
    }
}
