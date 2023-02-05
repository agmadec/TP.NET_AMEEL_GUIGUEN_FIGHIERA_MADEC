using ASP.Server.Database;
using ASP.Server.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Server.Api
{

    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext libraryDbContext;

        public BookController(LibraryDbContext libraryDbContext)
        {
            this.libraryDbContext = libraryDbContext;
        }

        public ActionResult<int> GetNbBook()
        {
            return libraryDbContext.Books.ToList().Count();
        }

        public ActionResult<List<BookWithoutContent>> GetBooks(int offset = 0, int limit = 10, [FromQuery] List<int> genre = null)
        {
            IQueryable<Book> books = libraryDbContext.Books
                .Include(book => book.Genres)
                .OrderBy(book => book.Id);
            if (genre != null && genre.Count > 0)
            {
                var genres = libraryDbContext.Genre.Where(g => genre.Contains(g.Id));
                books = books.Where(book => book.Genres.Intersect(genres).Any());
            }
            books = books
                .Skip(offset)
                .Take(limit);
            List<BookWithoutContent> bookList = books.Select(book => new BookWithoutContent { book = book }).ToList();
            return bookList;
        }

        public ActionResult<Book> GetBook(int id)
        {
            try
            {
                var book = libraryDbContext.Books.Where(book => book.Id == id).Include(book => book.Genres).First();
                return book;
            }
            catch (Exception)
            {
                return NotFound("Deso bb j'ai pas trouvé");
            }
        }

        public ActionResult<List<Genre>> GetGenres()
        {
            return libraryDbContext.Genre.ToList();
        }

    }
}

