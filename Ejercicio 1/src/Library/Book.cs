using System;

namespace SRP
{
    public class Book
    {
        private string Title { get ; }
        private string Author { get ; }
        private string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
