using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ebook : Book
    {
        // Propetys
        public int FileSize
        { get; set; } 

        public Ebook(string title, string author, int pages, int filesize) : base(title, author, pages)
        {
            FileSize = filesize;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {FileSize} MB";
        }
    }
}
