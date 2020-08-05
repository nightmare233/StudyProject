using System;
using System.Collections.Generic;
using System.Text;

namespace FishDemo
{
    public class FishingRod : SubscritionHub
    {
        public void Fishing()
        {
            Console.WriteLine("Begin fishing...");
            int randomNumber = new Random().Next() % 2;//随机数为偶数则为中鱼
            if (randomNumber == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("HeiPiao！");
                Notify(type);
            }
            else
            {
                Console.WriteLine("Nothing happened......");
            }
        }
    }
}
