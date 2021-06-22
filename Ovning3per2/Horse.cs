using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Horse: Animal
    {
        public bool IsKicking { get; }

        public Horse(bool IsKicking, string name, double weight, int age) :base(name, weight, age)
        {
            this.IsKicking = IsKicking;           
        }  

        public override void DoSound()=> Console.WriteLine("Jihaaa");     

        public override string Stats()=> $"The horse {Name} with weight {Weight}kg and age {Age} is kicking: {IsKicking}";   

        public override string ToString()=> IsKicking ? $"This is an animal, {Name}, which is kicking" : $"This is an animal, {Name}, which is not kicking";    

    }
}
