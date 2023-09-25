using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Pelican : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("POP! POPPP! POP!!");
        }


        public double BeakPouchSize { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Beak Pouch Size: {BeakPouchSize}";
        }
    }



}