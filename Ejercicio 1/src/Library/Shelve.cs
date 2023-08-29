using System;

namespace SRP
{
    public class Shelve {
        private string LibraryShelve { get ; set; }
        private Book book { get; set; }
        public Shelve(string shelve, Book book) {
            this.LibraryShelve = shelve;
            this.book = book;
        }
    }
}