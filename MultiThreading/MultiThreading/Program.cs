using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{

    public class MohamedThread
    {
        public static void ThreadMethod()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Number : " + x);
            }
        }
    }


    public class TamerThread
    {
        public void ThreadMethod()
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine("Name : " + th.Name);

            //for (int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("Number : " + x);
            //    Thread.Sleep(3000);
            //}
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "My Thread";
            //Console.WriteLine("Thread Name : " + th.Name);

            //Thread th1 = new Thread(new ThreadStart(MohamedThread.ThreadMethod));
            //Thread th2 = new Thread(new ThreadStart(MohamedThread.ThreadMethod));
            //th1.Start();
            //th2.Start();

            TamerThread obj = new TamerThread();
            Thread th1 = new Thread(new ThreadStart(obj.ThreadMethod));
            Thread th2 = new Thread(new ThreadStart(obj.ThreadMethod));
            Thread th3 = new Thread(new ThreadStart(obj.ThreadMethod));
            Thread th4 = new Thread(new ThreadStart(obj.ThreadMethod));
            th1.Name = "Player Mohamed";
            th2.Name = "Player Tamer";
            th3.Name = "Player Ali";
            th4.Name = "Player Osama";

            th1.Start();
            th1.Join();
            th2.Start();
            th3.Start();
            th4.Start();

            //try
            //{
            //    th1.Abort();
            //    th2.Abort();
            //}catch(ThreadAbortException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.WriteLine("End of App");
        }
    }
}
