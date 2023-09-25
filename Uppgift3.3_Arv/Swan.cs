using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Swan : Bird
    {
        public override void DoSound()
        {
            Console.WriteLine("TUT! TUUUT!");
        }
        public double NeckBendiness { get; set; }



        public override string Stats()
        {
            return base.Stats() + $", Neck Bendiness: {NeckBendiness}";
        }
    }



}