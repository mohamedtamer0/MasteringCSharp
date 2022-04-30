using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOverLoading
{

    class MathMatic
    {
        public int add(int x,int y)
        {
            return x + y;
        }

        public int add(int x, int y,int z)
        {
            return x + y + z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MathMatic obj = new MathMatic();
            Console.WriteLine("the results: " + obj.add(1, 2) + " " + obj.add(1, 2, 3));
        }
    }
}
