using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Wolf: Animal
    {
        public bool IsHowling { get; }

        public Wolf(bool IsHowling, string name, double weight, int age) : base(name, weight, age)
        {
            this.IsHowling = IsHowling;
            Name = "Wolf";
        }

        public Wolf(string name, double weight, int age) : base(name, weight, age) { }

        public override void DoSound()=> Console.WriteLine("Hoooowling.... hooooowling");    

        public override string Stats() => $"The wolf {Name} with weight {Weight}kg and age {Age} is howling? {IsHowling}";

        public override string ToString()=> IsHowling ? $"This is {Name}, which is howling" : $"This is {Name}, which is not howling";           
    }
}
