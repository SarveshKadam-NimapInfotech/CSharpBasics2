using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapestBook = books.FindAll(book => book.Price < 40);

            foreach (var book in cheapestBook)
            {
                Console.WriteLine(book.Title);

            }


        }

        //static bool IsCheaperThan40(Book book)
        //{
        //    return book.Price < 40;
        //}
    }
}
