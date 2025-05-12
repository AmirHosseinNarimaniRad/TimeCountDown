using System;
using System.Diagnostics;
using System.Threading;

namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number in seconds!");

            int Sec = Convert.ToInt32(Console.ReadLine());

            /*while (Sec >= 0)
            {
                Console.WriteLine(Sec);
                Thread.Sleep(1000); // pause the program for 1 second! 
                Sec--;
            }*/

            // To ensure more precise second intervals, use Stopwatch instead of relying solely on Thread.Sleep

            Stopwatch stopwatch = new Stopwatch();

            for (int i = Sec; i >=0; i--)
            {
                stopwatch.Restart();
                Console.WriteLine(i);

                while (stopwatch.ElapsedMilliseconds <1000)
                {
                    //wait until a second passes 

                    Thread.Sleep(10);//Use Thread.Sleep(10) in a timing loop to reduce CPU usage while waiting
                }
                    
                    
            }



            Console.WriteLine("Time's Up!");

            Console.ReadLine();
        }
    }
}
