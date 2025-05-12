using System;
using System.Threading;

namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number in seconds!");

            int Sec = Convert.ToInt32(Console.ReadLine());

            while (Sec >= 0)
            {
                Console.WriteLine(Sec);
                Thread.Sleep(1000); // pause the program for 1 second! 
                Sec--;
            }

            Console.WriteLine("Time's Up!");

            Console.ReadLine();
        }
    }
}
