using System;
using System.Collections.Generic;
using System.Text;

namespace BooksIRead
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public string BookYear { get; set; }
        public string BookPages { get; set; }


        public Book(lines line)
        {
            BookTitle = line.Title;
            BookAuthor = line.Author;
            BookPublisher = line.Publisher;
            BookYear = line.Year;
            BookPages = line.Pages;
        }

    }
}
