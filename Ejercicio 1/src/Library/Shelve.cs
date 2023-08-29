using System;

namespace SRP
{
    public class Shelve {
        private string LibraryShelve { get ; set; }
        private Book Book { get; set; }
        public Shelve(string shelve, Book book) {
            this.LibraryShelve = shelve;
            this.Book = book;
        }

        public string GetLibraryShelve() {
            return LibraryShelve;
        }
        public Book GetBook() {
            return this.Book;
        }

        public void SetLibraryShelve(string shelve) {
            if (!string.IsNullOrEmpty(shelve)) {
                this.LibraryShelve = shelve;
            }
        }
        public void SetBook(Book book) {
            if (book != null) {
                this.Book = book;
            }
        }
    }
}