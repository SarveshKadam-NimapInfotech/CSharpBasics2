using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var book = books.Single(b => b.Title == "ABC");
            //var book = books.SingleOrDefault(b => b.Title == "ABC");


            //var book = books.First(b=>b.Title == "DEF");
            //var book = books.FirstOrDefault(b => b.Title == "DEF");

            //var book = books.Last(b=>b.Title == "DEF");
            //var book = books.LastOrDefault(b => b.Title == "DEF");

            //Console.WriteLine(book.Title+" "+book.Price);


            //var pagedBooks = books.Skip(1).Take(3);

            //foreach (var pageBook in pagedBooks)
            //{
            //    Console.WriteLine(pageBook.Title);
            //}

            //var count = books.Count();
            //Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);

            var average = books.Average(b => b.Price);
            Console.WriteLine(average);



            ////Linq Query Operators
            //var cheaperBooks = 
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b;

            ////Linq Extension Methods
            //var cheapBooks = books
            //                     .Where(b => b.Price < 10)
            //                     .OrderBy(b => b.Title)
            //                     .Select(b => b.Title);



            //var cheapBooks = new List<Book>(); // using Linq we can write this expression as above
            //foreach (var book in books ) 
            //{
            //    if(book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks )
            //{
            //    Console.WriteLine(book.Title + " " +book.Price);
            //}

        }
    }
}
