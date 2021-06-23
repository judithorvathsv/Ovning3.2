using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Flamingo: Bird
    {
        public bool LongLegs { get; }

        public Flamingo(bool LongLegs, bool isFlying, string name, double weight, int age) : base(isFlying, name, weight, age)
        {
            this.LongLegs = LongLegs;
        }

        public override void DoSound() => Console.WriteLine("Flamingo sound... if it has something... ");

        public override string Stats() => $"{base.Stats()} has long legs: {LongLegs} is flying? {isFlying}";

        public override string ToString() => LongLegs ? $"This is {Name}, which has long legs" : $"This is {Name}, which has not long legs";
    }

}
