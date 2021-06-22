using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    class Swan: Bird
    {
        public bool IsWhite { get; }

        public Swan(bool IsWhite, bool isFlying, string name, double weight, int age) : base(isFlying, name, weight, age)
        {
            this.IsWhite = IsWhite;
        }

        public override void DoSound() => Console.WriteLine("Swan sound... I have never heard that... ");

        public override string Stats() => $"The bird {Name} with weight {Weight}kg and age {Age} is white: {IsWhite} is flying? {isFlying}";

        public override string ToString() => IsWhite ? $"This is {Name}, which is white" : $"This is {Name}, which is black";

    }
}
