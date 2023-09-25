using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Bird : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Kvitt! ... Kvitt kvitt, kvidderitt!");
        }


        public double WingSpan { get; set; }


        public override string Stats()
        {
            return base.Stats() + $", Wing span: {WingSpan}";
        }
    }



}