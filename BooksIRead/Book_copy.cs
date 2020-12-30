/* using System;
using System.Collections.Generic;
using System.Text;

namespace BooksIRead
{
    public class Book
    {
        protected string title;
        protected string author;
        protected string publisher;
        protected int year;
        protected int pages;
        protected string series;

        public Book() { }

        public Book(string t, string a, string b, int y, int p)
        {
            title = t;
            author = a;
            publisher = b;
            year = y;
            pages = p;
        }

        public Book(string t, string a, string b, int y, int p, string s)
        {
            title = t;
            author = a;
            publisher = b;
            year = y;
            pages = p;
            series = s;
        }

        public void DisplayBook()
        {
            if (series == null)
            {
                Console.WriteLine("Title: " + title + "\n" + "Author: " + author + "\n" + "Published by: " + publisher + "\n"
                              + "Published: " + year + "\n" + "Pages: " + pages + "\n");
            }
            else 
            {
                Console.WriteLine("Title: " + title + "\n" + "Author: " + author + "\n" + "Published by: " + publisher + "\n"
                              + "Published: " + year + "\n" + "Pages: " + pages + "\n" + "Series: " + series + "\n");
            }
        }

    }
}  */
