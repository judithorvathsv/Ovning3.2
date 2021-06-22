using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per2
{
    public class Wolfman : Wolf, IPerson
    {
        public bool IsAMan { get; }

        public Wolfman(bool IsAMan, bool IsHowling, string name, double weight, int age):base(IsHowling,name, weight, age)
        {
            IsAMan = true;
            IsHowling = false;
            this.Name = name;
        }

        public override void DoSound()=> Console.WriteLine("hm.... ");      

        public void Talk() => Console.WriteLine("It's time to run!");     

        public override string ToString()=> $"This is {Name}, the Wolfman";
     


        //bara för att prova att det också fungerar... 
        public Wolfman(string name, double weight, int age) : base(name, weight, age) { } 
    }
}
