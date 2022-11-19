using OperatorOverloading_Indexer_Reflection.Controller;
using OperatorOverloading_Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OperatorOverloading_Indexer_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Practice
            #region Homework-Practice
            //PersonController.ShowAll();

            //BookController.GetCount();

            //EmployeeController.GetAverageSalary();
            #endregion



            //Console.WriteLine(GetBook());

            //PersonController.GetFilteredPersonsPowCount();



            //Person person1 = new Person();
            //person1.Age = 25;
            //Person person2 = new Person();
            //person2.Age = 21;

            //var result = person1 > person2;

            //Console.WriteLine(result);



            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(nums[3]);

            //Book book1 = new Book();
            //book1.Name = "Xosrov1";
            //book1.Author = "Nizami1";
            //Book book2 = new Book();
            //book2.Name = "Xosrov2";
            //book2.Author = "Nizami2";
            //Book book3 = new Book();
            //book3.Name = "Xosrov3";
            //book3.Author = "Nizami3";

            //Library library = new Library();

            //library[0] = book1;
            //library[1] = book2;
            //library[2] = book3;

            //Console.WriteLine(library[0].Name + " " + library[0].Author);
            //Console.WriteLine(library[1].Name + " " + library[1].Author);
            //Console.WriteLine(library[2].Name + " " + library[2].Author);

            //Assembly assembly = Assembly.GetExecutingAssembly();

            //foreach (var item1 in assembly.GetTypes())
            //{
            //    //Console.WriteLine(item1);

            //    foreach (var item2 in item1.GetMembers())
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            #endregion

            #region Homework
            //List<Library> libraries = new List<Library>();

            //Library library1 = new Library();

            //Library library2 = new Library();

            //Book book1 = new Book()
            //{
            //    Name = "Xosrov",
            //    Author = "Nizami"
            //};
            //Book book2 = new Book()
            //{
            //    Name = "Sirin",
            //    Author = "Nizami"
            //};
            //Book book3 = new Book()
            //{
            //    Name = "Sikayetname",
            //    Author = "Fuzuli"
            //};
            //Book book4 = new Book()
            //{
            //    Name = "Sevil",
            //    Author = "Huseyn Cavid"
            //};

            //library1[0] = book1;
            //library1[1] = book2;

            //library2[0] = book3;
            //library2[1] = book4;

            //libraries.Add(library1);
            //libraries.Add(library2);

            //foreach (var item1 in libraries)
            //{
            //    Console.WriteLine(item1[0].Name + " " + item1[0].Author);
            //}
            #endregion

        }

        public static Book GetBook()
        {
            Book book = new Book() { Name = "Xosrov", Author = "Nizami" };

            return book;
        }
    }
}