using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        // Propetys
        public string Title
        { get; private set; }

        public string Author
        { get; private set; }

        public int Pages 
        { get; private set; }

        // Constructors
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        // Methods

        public virtual string GetDescription()
        {
            return ($"{Title} by {Author}, {Pages} pages");
                       
        }
    }
}
