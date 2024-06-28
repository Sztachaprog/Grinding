// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        // Constructor
        public Mage(string title) : base(title) { }
        public Mage(string title, string origin) : base(title, origin) { }


        // Method
        public virtual Storm CastRainStorm()
        {
            Storm s = new Storm("rain", false, Title);
            return s;
        }
    }

}
