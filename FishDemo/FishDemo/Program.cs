using System;
using System.Threading;

namespace FishDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Go，Let's fishing！");
            Console.WriteLine("****************************hahaha, so happy..******************************");
            var fishRod = new FishingRod();

            var frank = new FishingMan("Frank");

            fishRod.AddSubscriber(frank);
            while (frank.Count < 5)
            {
                fishRod.Fishing();
                Console.WriteLine("---------------------------");
                Thread.Sleep(2000);
            }
        }
    }
}
