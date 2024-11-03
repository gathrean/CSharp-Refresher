using System;
using System.Threading;

namespace MultithreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multithreading

            // Thread   = An execution path of a program
            //          = We can use multiple threads to perform
            //            different tasks of our program at the same time.
            //          = Current thread running is "main" thread using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            // ^ this will assign the current thread that is running to a local variable mainThread

            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer #1")); // in charge of counting down
            Thread thread2 = new Thread(() => CountUp("Timer #2")); // in charge of counting up

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete!");

            Console.ReadKey();
        }
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000); // 1 second
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000); // 1 second
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}