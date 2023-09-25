using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Wolf : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Ahh-wooooooo!");
        }

        public double HowlLoudness { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Howl Loudness: {HowlLoudness}";
        }
    }

}