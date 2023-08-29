using System;

namespace SRP
{
    public class Shelve {
        public string LibraryShelve { get ; set; }
        public Book book { get; set; }
        public Shelve(string shelve, Book book) {
            this.LibraryShelve = shelve;
            this.book = book;
        }
    }
}