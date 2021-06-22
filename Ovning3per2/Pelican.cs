using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Pelican: Bird
    {
        public bool HasBigBeak { get; }

        public Pelican(bool HasBigBeak, bool isFlying, string name, double weight, int age) :base(isFlying, name, weight, age)
        {
            this.HasBigBeak = HasBigBeak;
   
        }

        public override void DoSound() => Console.WriteLine("pelikan sound... not crip... ");

        public override string Stats() => $"The bird {Name} with weight {Weight}kg and age {Age} has big beak: {HasBigBeak} is flying? {isFlying}";

        public override string ToString() => HasBigBeak ? $"This is {Name}, which has big beak" : $"This is {Name}, which has not big beak";

    }
}
