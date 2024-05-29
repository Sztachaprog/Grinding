using ConsoleApp1;

class Program
{
    static void Main()
    {
        // Ebook initalization
        Ebook ebook = new Ebook("dziady", "mickiewicz", 12, 12);

        Console.WriteLine(ebook.GetDescription());


        // Book initalization
        Book book = new Book("dziady", "mickiewicz", 12);

        Console.WriteLine(book.GetDescription());



    }
}