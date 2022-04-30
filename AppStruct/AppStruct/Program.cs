using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStruct
{

    struct Result
    {
        public int num1;
        public int num2;

        public Result(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Sum is : " + (num1 + num2));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Result res = new Result(10,20);  
            res.PrintInfo();
        }
    }
}
