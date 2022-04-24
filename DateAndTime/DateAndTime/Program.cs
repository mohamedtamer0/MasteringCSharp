using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2022, 4, 24);
            DateTime myToday = DateTime.Now;
            Console.WriteLine("Date is : " + myToday.ToString("MMMM d/yyyy"));
            Console.WriteLine("Date is : " + myDate.ToString("M/d/yyyy"));
        }
    }
}
