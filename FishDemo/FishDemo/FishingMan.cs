using System;
using System.Collections.Generic;
using System.Text;

namespace FishDemo
{
    public class FishingMan : ISubscriber
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public FishingMan(string name)
        {
            Name = name;
        }
        public void Update(FishType type)
        {
            Count++;
            Console.WriteLine($"{Name}got a {type}, Totally got {Count} fishes！");
        }
    }
}
