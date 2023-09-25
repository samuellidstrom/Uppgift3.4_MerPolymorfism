using System.Threading.Channels;

namespace Uppgift3_4_MerPolymorfism
{
    internal class Dog : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Voff. Vov-vov-voff!");
        }


        public double HatredOfCats { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", Hatred of cats: {HatredOfCats}";
        }

        // Det är (vet jag nu efter att jag kollade) mer komplicerat att räkna ut hundår än att bara mutltiplicera med 7.
        // Men det känns inte som att det är det som är fokus för övningen ändå. :)
        public string GetDogAge()
        {
            if (Age == 0)
            {
                return Age.ToString();
            }

            return Convert.ToString((double)Age * 7);
        }


    }



}