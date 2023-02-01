using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Database;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Server.Controllers
{
    public class CreateGenreModel
    {
        public string Name { get; set; }
        public List<int> Books { get; set; }
        public IEnumerable<Book> AllBooks { get; set; }
    }
    public class GenreController : Controller
    {
        private readonly LibraryDbContext libraryDbContext;

        public GenreController(LibraryDbContext libraryDbContext)
        {
            this.libraryDbContext = libraryDbContext;
        }

        // A vous de faire comme BookController.List mais pour les genres !
        public ActionResult<IEnumerable<Genre>> List(int offset = 0, int limit = 10, [FromQuery] List<int> genre = null)
        {
            List<Genre> ListGenres = libraryDbContext.Genre.ToList();
            return View(ListGenres);
        }

        public ActionResult<CreateGenreModel> Create(CreateGenreModel genre)
        {
            return View(new CreateGenreModel() { AllBooks = libraryDbContext.Books.ToList() });
        }
    }
}
