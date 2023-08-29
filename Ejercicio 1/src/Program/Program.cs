using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            // Loc.book1
            Shelve she1 = new Shelve("7", book1);
            Sector sec1 = new Sector("A", she1);

            // Loc.book2
            Shelve she2 = new Shelve("3", book2);
            Sector sec2 = new Sector("B", she2);
        }
    }
}