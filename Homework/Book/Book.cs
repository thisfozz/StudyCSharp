﻿using System;
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

        public static bool operator !=(Book a, Book b)
        {
            return a != b;
        }
        public static bool operator ==(Book a, Book b)
        {
            return a == b;
        }
    }
}
