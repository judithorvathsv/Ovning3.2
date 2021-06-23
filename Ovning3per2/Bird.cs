using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Bird: Animal
    {
        public bool isFlying { get; }

        public Bird(bool isFlying, string name, double weight, int age) : base(name, weight, age)
        {
            this.isFlying = isFlying;           
        }
        public override void DoSound()=> Console.WriteLine("Crip Crip... ");     

        public override string Stats()=> $"{base.Stats()} is flying? {isFlying}";

        public override string ToString()=> isFlying ? $"This is {Name}, which can fly" : $"This is {Name}, which cannot fly";      

    }
}
