using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.Book
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Title} ({Author}, {Year})";
        }

        public static bool operator !=(Book sourseBook, Book bookOther)
        {
            return sourseBook != bookOther;
        }
        public static bool operator ==(Book sourseBook, Book bookOther)
        {
            return sourseBook == bookOther;
        }

        // If it is necessary to sort the books by the release date, the corresponding implementation has been made.
        public static bool operator >(Book sorseBook, Book bookOther)
        {
            return sorseBook.Year > bookOther.Year;
        }
        public static bool operator <(Book sorseBook, Book bookOther)
        {
            return sorseBook.Year < bookOther.Year;
        }
    }
}
