using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Hedgehog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Gruff... Gruff... Sniff, sniff.");
        }

        public double NrOfSpikes { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Number of spikes: {NrOfSpikes}";
        }
    }



}