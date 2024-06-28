// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {

        // Constructor

        public Storm (string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        // Methods

        public override string Announce()
        {
            if (IsStrong == true)
            {
                return $"{Caster} cast a strong {Essence} strom";
            }
            else
            {
                return $"{Caster} cast a weak {Essence} storm";
            }

        }

    }

}
