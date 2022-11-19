using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Services
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();

            return books.FindAll(predicate).Count;
        }

        private List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book()
            {
                Author = "Nizami"
            };
            Book book2 = new Book()
            {
                Author = "Nizami"
            };
            Book book3 = new Book()
            {
                Author = "Fuzuli"
            };
            Book book4 = new Book()
            {
                Author = "Nesimi"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);

            return books;
        }
    }
}
