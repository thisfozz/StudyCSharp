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
                Console.Write("Книга добавлена.");
            }
            else
            {
                Console.Write("Такая книга уже есть в списке");
            }
        }
        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.Write("Книга удалена.");
            }
            else
            {
                Console.Write("Такой книги нет в списке");
            }
        }
        
        public bool ContainsBook(Book book)
        {
            return books.Contains(book);
        }
    }
}
