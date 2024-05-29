using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYADatingApp
{
    internal class Profile
    {
        // Fields
        private string name { get; set; }
        private int _age;
        private int age 
        {
            get { return _age; }
            set 
            { 
                if (age >= 18) 
                { 
                    _age = value;
                }
                else 
                {
                    Console.WriteLine("You are too young");
                    Environment.Exit(0);
                }
            }
        }
        private string city { get; set; }
        private string country { get; set; }
        private string pronouns { get; set; }
        private string[] hobbies { get; set; }

        // Constructors
                                                           //pronouns optional parameter with a default valueoptional parameter with a default value
        public Profile(string name, 
            int age, 
            string city = "N/A", 
            string country = "N/A", 
            string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        // Methods

        /* public void ViewProfil()
         {
              Console.WriteLine($"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}");
         }
        +
        // profile.ViewProfil(); in Main method
        */
        public string ViewProfil()
        {
            string bio = ($"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}");
           
            bio += "\nHobbies:\n";
            foreach(string hobby in hobbies)
            {
                bio += $"- {hobby}\n";
            }
            return bio;
        }

       public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
