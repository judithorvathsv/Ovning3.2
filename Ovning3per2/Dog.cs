using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Dog: Animal
    {
        public bool IsHappy { get; }

        public Dog(bool IsHappy, string name, double weight, int age) : base(name, weight, age)
        {
            this.IsHappy = IsHappy;      
        }

        public override void DoSound()=> Console.WriteLine("Wuffff");    

        public override string Stats()=> $"The dog {Name} with weight {Weight}kg and age {Age} is happy: {IsHappy}";     

        public override string ToString()=> IsHappy ? $"This {Name}, which is happy" : $"This is {Name}, which is not happy";   
       


        // 15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng:  
        public override string Jump()=> $"Jump {Name}!";
   
    }
}
