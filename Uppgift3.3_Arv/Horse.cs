using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Horse : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Hei-he-he-he-hou-hou-hu-huu-huuu! ...Pfrrrrrrr....");
        }

        public double HoofHardness { get; set; }


        public override string Stats()
        {
            return base.Stats() + $", Hoof Hardness: {HoofHardness}";
        }
    }



}