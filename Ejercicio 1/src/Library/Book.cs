using System;

namespace SRP
{
    public class Book
    {
        private string Title { get; set;}
        private string Author { get; set;}
        private string Code { get; set;}

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public string GetTitle() {
            return this.Title;
        }
        public string GetAuthor() {
            return this.Author;
        }
        public string GetCode() {
            return this.Code;
        }

        public void SetTitle(string title) {
            if (!string.IsNullOrEmpty(title)) {
                this.Title = title;
            }
        }
        public void SetAuthor(string author) {
            if (!string.IsNullOrEmpty(author)) {
                this.Author = author;
            }
        }
        public void SetCode(string code) {
            if (!string.IsNullOrEmpty(code)) {
                this.Code = code;
            }
        }
    }
}
