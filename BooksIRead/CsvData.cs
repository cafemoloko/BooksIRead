using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace BooksIRead 
{
    public class CsvData : IData
    {
        private int titleIndex = 0;
        private int authorIndex = 1;
        private int publisherIndex = 2;
        private int yearIndex = 3;
        private int pagesIndex = 4;


        public string GetPath()
        {
            var relativePath = @"C:\Users\Karolina Piekarz\source\repos\BooksIRead\BooksIRead\BooksIRead\books.csv";
            return relativePath;
        }

        public List<lines> ReadData()
        {
            List<lines> books = new List<lines>();

            string[] csvLines = File.ReadAllLines(GetPath()).Skip(1).ToArray();
            foreach (string line in csvLines)
            {
                string[] splitLine = line.Split(';');
                int numberOfColumns = splitLine.Length;

                if (numberOfColumns == 5)
                {
                    books.Add(new lines
                    {
                        Title = splitLine[titleIndex],
                        Author = splitLine[authorIndex],
                        Publisher = splitLine[publisherIndex],
                        Year = splitLine[yearIndex],
                        Pages = splitLine[pagesIndex]

                    });  
                      
                }
            }

            return books;
        }

    }
}



