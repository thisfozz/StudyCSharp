using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.Book
{
    internal class MenegerBook
    {
        private List<Book> books;

        public MenegerBook()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if(!books.Contains(book))
            {
                books.Add(book);
            }
            else
            {
                Console.Write("Такая книга уже есть в списке");
            }
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        
        public bool ContainsBook(Book book)
        {
            return books.Contains(book);
        }
        
        // Какие операторы тут можно перегрузить?
    }
}
