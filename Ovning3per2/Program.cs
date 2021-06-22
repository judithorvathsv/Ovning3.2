using System;
using System.Collections.Generic;

namespace Ovning3per2
{
   public class Program
    {
        public static void Main(string[] args)
        {

            //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det? -- i Bird klass
            //14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? -- i Animal klass




            // 4. Skapa några djur (av olika typ) i din lista:
            List<Animal> animals = new List<Animal>();
            
            animals.Add(new Wolf(true, "BigWolf", 32.4, 8));
            animals.Add(new Bird(true, "LittleBird", 1.4, 1));
            animals.Add(new Swan(true,true, "WhiteSwan", 2, 3));
            animals.Add(new Dog(true, "Fiffi", 23.2, 7));
            animals.Add(new Worm(true, "OMG", 0.1, 1));
            animals.Add(new Dog(false, "OlderFiffi", 41.3, 2));
            animals.Add(new Wolfman(true,false, "CrazyMan", 81, 30));
            animals.Add(new Hedgehog(false, "Thorny", 41.3, 2));
            animals.Add(new Wolfman("James", 91, 60));





            // 5. Skriv ut vilka djur som finns i listan med hjälp av en foreach-loop
            // 6. Anropa även Animals Sound() metod i foreach-loopen
            Console.WriteLine("Animals in the list with sound:");
            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.DoSound();
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");





            // 7.Gör en check i For-loopen ifall animal även är av typen Person, om den är det typ - casta till Person och anropa dess Talk() metod:
            Console.WriteLine("Talking person:");
            for (int i = 0; i < animals.Count; i++)
            {      
                if(animals[i] is IPerson)
                {
                    IPerson person = (IPerson)animals[i];
                    Console.Write(person.ToString() + ". Person is saying: ");
                    person.Talk();
                }            
            }
            Console.WriteLine("----------------------");





            //8. Skapa en lista för hundar:
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog(true, "Admiral", 80.6, 3));
            dogs.Add(new Dog(false, "Bartley", 13.2, 4));
            dogs.Add(new Dog(true, "Chase", 31.7, 7));

            // dogs.Add(new Horse(true));
            //9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det? -- List<Dog> innehåller bara hundar med hund property. Häst kan gå in i List<Horse> med egna properties.
            //10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? -- List animals = new List();  non-generic





            // 11. Skriv ut samtliga Animals Stats() genom en foreach loop:
            Console.WriteLine("Printing Animal Stats() method: ");
            foreach (var animal in animals)
            {               
                Console.WriteLine(animal.Stats(animal.Name));
            }       
            Console.WriteLine("----------------------");
            // 13. F: Förklara vad det är som händer: foreach går igenom alla animal somm finns i listan, sedan använder Stats(string name) i Animal class. Eftersom Stats(string name) inte är Stats() finns det ingen override.
            // Det "call" Stats(string name) i Animal klassen istället Stats() som har override i olika animal klasserna. Om man "call" Stats() ska man får Stats() från animal klasserna pga override.





            //Det är för Stats (från olika animals) för alla animals i listan:
            Console.WriteLine("Printing different animal Stats() method: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            Console.WriteLine("----------------------");




            // 14. Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals:
            Console.WriteLine("Stats() for Dogs");
            foreach (var item in animals)
            {
                if (item is Dog)
                    Console.WriteLine(item.Stats());
            }
            Console.WriteLine();






            // 15. Skapa en ny metod med valfritt namn i klassen Dog... 16. Kommer du åt den metoden från Animals listan? --Nej
            // 17. F: Varför inte?  -- Eftersom det inte finns Jump i Animal klassen och det är en lista för Animal, alltså vi går igenom Animal listan som använder metoder från Animal. 
            //  Console.WriteLine("Jump() for Dogs");
            //foreach (var item in animals)
            {
                  //  if (item is Dog)
                  //  Console.WriteLine(item.Jump());    om det inte finns virtual i Animal och override i Dog går det inte få Jump() från Dog klass.
            }
            //Console.WriteLine();






            // 18.Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
            Console.WriteLine("Jump() for Dogs");
            foreach (var item in animals)
            {
                if (item is Dog)
                {
                    Dog d = (Dog)item;
                    Console.WriteLine(item.Jump());
                }
            }
            Console.WriteLine();   

        }

    }
}

