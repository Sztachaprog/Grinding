using OOYADatingApp;
using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakilla", 17, "New York", "USA");

            
            sam.SetHobbies(new string[]
           { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickbal", "writing a speculative fiction novel", "reading advice columns" });
            Console.WriteLine(sam.ViewProfil());
            

        }
    }
}