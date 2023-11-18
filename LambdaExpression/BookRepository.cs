﻿using System.Collections.Generic;

namespace LambdaExpression
{
    internal partial class Program
    {
        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 6},
                new Book() {Title = "Title 2", Price = 10},
                new Book() {Title = "Title 3", Price = 55}
            };
            }
        }
    }
}
