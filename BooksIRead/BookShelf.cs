using System;
using System.Collections.Generic;
using System.Text;

namespace BooksIRead
{
    class BookShelf : IBook
    {
        private List<BookShelf> books = new List<BookShelf>();

        public BookShelf()
        {
            foreach(var line in data.ReadData())
            {
                books.Add(new Book(line));
            }
        }
        public List<BookShelf> DisplayBooks()
        {
            
            throw new NotImplementedException();
        }

        private IData data;
        public BookShelf(IData data)
        {
            this.data = data;
        }
    }
}
