using System.Globalization;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Svar på fråga 3.4.9.F:
            // Fråga: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Svar: Båda ärver från klassen Animal, men är separata klasser


            // Svar på fråga 3.4.10.F:
            // Fråga: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // Svar: Då behöver listan innehålla klassen Animal

            // Svar på fråga 3.4.13.F:
            // Fråga: Förklara vad det är som händer.
            // Svar: Varje djurs override:ade Stats-metod anropas för att få fram djurets unika egenskaper.
            //       Därefter anropar basklassernas Stats-metoder för att få fram de gemensamma egenskaperna.

            // Svar på fråga 3.4.17.F:
            // Fråga: Kommer du åt den metoden från Animals listan? - Varför inte?
            // Svar:  GetDogAge-metoden finns bara på Dog-klassen och kan därför bara anropas från den klassen och klasser som ärver från den klassen.
            //        Eftersom listan skulle kunna visa alla djur behövde den vara av klassen Animal, eftersom det är basklassen för alla olika djur.


            Dog Dizzy = new Dog() { Name = "Dizzy", Age = 5, Weight = 13.3, HatredOfCats = 4 };
            Wolfman Ulf = new Wolfman() { Name = "Ulf", Age = 42, Weight = 85.3, HowlLoudness = 142, PeopleEaten = 2014};
            Pelican Harry = new Pelican() { Name = "Harry", Age =12, Weight = 25.3, BeakPouchSize = 23, WingSpan = 173};
            Horse Brunte = new Horse() { Name = "Brunte", Age =5, Weight = 110.3, HoofHardness = 21};
            Swan Sven = new Swan() { Name = "Sven", Age = 19, Weight = 25.7, WingSpan = 1.5, NeckBendiness = 3};
            Worm Valle = new Worm() { Name = "Valle", Age = 1, Weight = 0.01, Bendiness = 5.1};
            Flamingo Fredrik = new Flamingo() { Name = "Fredrik", Age = 17, Weight = 4.7, WingSpan = 2.1, AmountOfPinkness = 134};
            Hedgehog Helga = new Hedgehog() { Name = "Helga", Age = 8, Weight = 2.7, NrOfSpikes = 835};
            Dog Limbo = new Dog() { Name = "Limbo", Age = 3, Weight = 3.3, HatredOfCats = 16 };
            Dog Greta= new Dog() { Name = "Greta", Age = 12, Weight = 4.1, HatredOfCats = 0.5 };
            Dog Erik = new Dog() { Name = "Erik", Age = 8, Weight = 7.4, HatredOfCats = 4.7 };



            //List<Dog> dogs = new List<Dog>();
            //Horse Brunte = new Horse();
            //dogs.Add(Brunte);            


            List<Animal> animals = new List<Animal>();

            animals.Add(Dizzy);
            animals.Add(Ulf);
            animals.Add(Harry);
            animals.Add(Brunte);
            animals.Add(Sven);
            animals.Add(Valle);
            animals.Add(Fredrik);
            animals.Add(Helga);
            animals.Add(Limbo);
            animals.Add(Greta);
            animals.Add(Erik);
            


            foreach (var item in animals)
            {
                Console.WriteLine(item.Stats());
                Console.Write("Making sound: ");
                item.DoSound();
                if (item is IPerson person)
                {
                    Console.Write("Talking like this: ");
                    person.Talk();
                }
                if (item is Dog dog)
                {
                    Console.Write("Age in dog years: ");
                    string dogAge = dog.GetDogAge();
                    Console.WriteLine(dogAge);                    
                }
                Console.WriteLine();

            }
            Console.WriteLine("\n");
            Console.WriteLine("Alla hundar:");
            foreach (var item in animals)
            {
                if (item is Dog)
                {
                    Console.Write("  ");
                    Console.WriteLine(item.Stats());                    
                }
                //Console.WriteLine();
            }





        }
    }
}