using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////////////////////////////////

            int[] numbers = {10,20,30,40,50};
            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }

            /////////////////////////////////////////////////////

            string[] names = {"Mohamed","Tamer","Osama","Ali","Mohab"};
            foreach(var v in names)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Length : " + names.Length);

            /////////////////////////////////////////////////////


            myNames(names);

            /////////////////////////////////////////////////////

            int[] myArray = new int[4];
            myArray[0] = 15;
            myArray[1] = 30;
            myArray[2] = 40;
            myArray[3] = 55;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            /////////////////////////////////////////////////////

            int[,] array2D = new int[3, 3];
            array2D[0,1] = 15;
            array2D[1,2] = 30;
            array2D[2,0] = 40;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write(array2D[i, j]);
                }
                Console.WriteLine();
            }


        }


        static void myNames(string[] names)
        {
            foreach (var v in names)
            {
                Console.WriteLine(v);
            }
        }
    }
}
