using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ProgrammingLanguages
{
    class Program
    {

        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
                                      .Skip(1)
                                      .Select(line => Language.FromTsv(line))
                                      .ToList();

            /*foreach (var language in languages)
            {
                Console.WriteLine(language.Prettify());
            }*/

            var yearNameChief = from i in languages
                                select $"Language Year: {i.Year} Name: {i.Name} and Developer: {i.ChiefDeveloper}";

            /*foreach (var item in yearNameChief)
            {
                Console.WriteLine(item);
            }*/


            var cSharp = languages
                .Where(h => h.Name.Contains("C#"));

            /* foreach (var es in smth)
             {
                 Console.WriteLine(es.Prettify());
             }*/

            var microsoft = languages
                 .Where(h => h.ChiefDeveloper.Contains("Microsoft"));

            /*foreach (var es in microsoft)
            {
                Console.WriteLine(es.Prettify());
            }*/

            var lisp = languages
                 .Where(h => h.Predecessors.Contains("Lisp"));
            /*foreach (var es in lisp)
            {
                Console.WriteLine(es.Prettify());
            }*/

            var script = languages
                 .Where(h => h.Name.Contains("Script"));

            /*foreach (var es in script)
            {
                Console.WriteLine(es.Prettify());
            }*/

            var howManyLanguages = languages.Count(h => h.Year >= 1995 && h.Year <= 2005);
            //Console.WriteLine(howManyLanguages);

            var nameYear = from i in languages
                           select $"{i.Name} was invented in {i.Year}";
            /*foreach (var language in nameYear)
            {
                Console.WriteLine(language);
            }*/
            PrettyPrintAll(languages);
            PrintAll(nameYear);



        }
        public static void PrettyPrintAll(IEnumerable<Language> langs)
        {
            
            foreach ( var es in langs)
            {
                Console.WriteLine(es.Prettify());
            }
        }
        public static void PrintAll(IEnumerable<Object> es)
        {
            foreach (Object ja in es)
            {
                Console.WriteLine(ja);
            }
        }
    }
}
