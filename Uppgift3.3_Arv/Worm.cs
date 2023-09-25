using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Worm : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Plopp.. plopp, plopp.");
        }

        public double Bendiness { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Bendiness: {Bendiness}";
        }
    }

    

}