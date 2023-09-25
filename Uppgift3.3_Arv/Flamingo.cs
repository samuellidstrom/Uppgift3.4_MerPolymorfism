using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Flamingo : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("HOONK! HONK-GRUNT, GROWL!");
        }


        public double AmountOfPinkness { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Amount of pinkness: {AmountOfPinkness}";
        }


    }



}