using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }        

        public Animal(string name, double weight, int age) {
            Name = name;
            Weight = weight;
            Age = age;
        }
        public abstract void DoSound();
       
        public virtual string Stats() => $"The name is {Name}, the weight is {Weight} and the age is {Age} for this animal";          

        public string Stats(string name)=> $"The name is {Name}, the weight is {Weight} and the age is {Age} for this animal";     

        public virtual string Jump()=> "Jump Animal!";
      
        public Animal() { }
    }
}
