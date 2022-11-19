﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Book[] _books { get; set; }

        public Library(int size = 100)
        {
            _books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }
    }
}