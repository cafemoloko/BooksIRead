using System;

namespace BooksIRead
{
    class Program
    {
        static void PrintBook(Book books)
        {
            Console.WriteLine($"Title: {books.BookTitle}");
            Console.WriteLine($"Author: {books.BookAuthor}");
            Console.WriteLine($"Publisher: {books.BookPublisher}");
            Console.WriteLine($"Year: {books.BookYear}");
            Console.WriteLine($"Pages: {books.BookPages}");
        }
        static void Main(string[] args)
        {
            IData book = new CsvData();
            //Book bookShelf = new Book(book);
            

           
        }
    }
}
