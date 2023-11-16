using System.Collections.Generic;

namespace Linq
{
  
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ABC", Price = 5 },
                new Book() {Title = "BCD", Price = 1 },
                new Book() {Title = "DEF", Price = 2 },
                new Book() {Title = "DEF", Price = 7 },

            };
        }
    }
    
}
