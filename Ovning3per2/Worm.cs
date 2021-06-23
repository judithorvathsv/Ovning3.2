using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Worm: Animal
    {
        public bool IsDisgusting { get;  }

        public Worm(bool IsDisgusting, string name, double weight, int age) : base(name, weight, age)
        {
            this.IsDisgusting = IsDisgusting;          
        }

        public override void DoSound()=> Console.WriteLine("Eh... too long way to the apple ");    

        public override string Stats() => $"{base.Stats()} is cute? {!IsDisgusting}";
        
        public override string ToString()=> IsDisgusting ? $"This is {Name}, which is disgusting" : $"This is {Name}, which is  cute";  
      
    }
}
