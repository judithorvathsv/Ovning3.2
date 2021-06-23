using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Hedgehog: Animal
    {
        public bool IsCute { get; }

        public Hedgehog(bool IsCute, string name, double weight, int age) : base(name, weight, age)
        {
            this.IsCute = IsCute;      
        }

        public override void DoSound() => Console.WriteLine("I am running.. running...");       

        public override string Stats()=> $"{base.Stats()} is cute? {IsCute}";
       
        public override string ToString()=> IsCute ? $"This is {Name}, which is cute" : $"This is {Name}, which is not cute";    

    }
}
