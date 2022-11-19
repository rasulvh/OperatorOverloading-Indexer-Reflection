using OperatorOverloading_Indexer_Reflection.Services;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Controller
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookService bookService = new BookService();

            Console.WriteLine(bookService.GetCount(m => m.Author == "Nizami"));
        }
    }
}
