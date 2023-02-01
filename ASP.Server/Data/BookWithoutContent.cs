using System.Collections.Generic;

namespace ASP.Server.Model
{
    public class BookWithoutContent
    {
        public Book book { private get; set; }
        public int Id { get { return book.Id; } }

        public string Title { get { return book.Title; } }

        public string Author { get { return book.Author; } }
        
        public float Price { get { return book.Price; } }

        public List<Genre> Genres { get { return book.Genres; } }
    }
}
