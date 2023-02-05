using ASP.Server.Database;
using ASP.Server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ASP.Server.Controllers
{
    public class CreateGenreModel
    {
        [Required]
        [Key]
        public string Name { get; set; } = "";
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
            if (ModelState.IsValid)
            {
                libraryDbContext.Add(new Genre() { Name = genre.Name });
                libraryDbContext.SaveChanges();
            }
            return View(new CreateGenreModel());

        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(List));
            }
            Genre genreToDelete = libraryDbContext.Genre.Where(genre => genre.Id == id).First();
            libraryDbContext.Remove(genreToDelete);
            libraryDbContext.SaveChanges();
            return RedirectToAction(nameof(List));
        }
    }
}
