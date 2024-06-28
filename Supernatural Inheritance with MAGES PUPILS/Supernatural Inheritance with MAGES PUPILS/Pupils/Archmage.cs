// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title) { }
        public Archmage(string title, string origin) : base(title, origin) { }

        // Methods
        public override Storm CastRainStorm()
        {
            Storm r = new Storm("rain", true, Title);
            return r;
        }

        //definiowanie metody w klasie, która tworzy i zwraca instancję klasy Storm.
        public Storm CastLightningStorm()
        {
            Storm l = new Storm("lightning", true, Title);
            return l;
        }
    }
   
}
