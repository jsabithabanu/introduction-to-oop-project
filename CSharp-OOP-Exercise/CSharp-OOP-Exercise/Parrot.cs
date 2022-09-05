using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_OOP_Exercise
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"Hello there! I'm {Name} and I'm a cute talking {Color} parrot.");
        }

        public override void Fly()
        {
            Console.WriteLine($"Yahoooo! I can spread out my wings and fly!");
        }
    }
}