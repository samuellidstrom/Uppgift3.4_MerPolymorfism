using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Wolfman : Wolf, IPerson
    {
        
        public void Talk()
        {
            Console.WriteLine("Hello, there.. Oh! I'ts a full mooooOOOOON-AHwooooooo!");
        }

        public int PeopleEaten { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Number of people eaten: {PeopleEaten}";
        }

    }

}