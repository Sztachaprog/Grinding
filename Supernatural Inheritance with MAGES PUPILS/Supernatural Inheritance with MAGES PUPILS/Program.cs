using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] stormes = new Storm[10];
            int stormsIndex = 0;


            // creating instance of Pupil constructor 
            Pupil p = new Pupil("Mezil-kree");
            stormes[stormsIndex] = p.CastWindStorm();
            stormsIndex++;



            Mage m = new Mage("Gul’dan");
            stormes[stormsIndex] = m.CastRainStorm();
            stormsIndex++;


            Archmage a = new Archmage("Nielas Ara");
            stormes[stormsIndex] = a.CastWindStorm();
            stormsIndex++;

            stormes[stormsIndex] = a.CastRainStorm();
            stormsIndex++;

            stormes[stormsIndex] = a.CastLightningStorm();
            stormsIndex++;

            for (int i = 0; i < stormsIndex; i++)
            {
                Console.WriteLine(stormes[i].Announce());
            }
        }
    }
}