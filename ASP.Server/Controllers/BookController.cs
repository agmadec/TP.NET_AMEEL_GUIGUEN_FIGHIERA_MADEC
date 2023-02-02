using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Database;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;

namespace ASP.Server.Controllers
{
    public class CreateBookModel
    {
        [Display(Name = "Titre")]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public float Price { get; set; } = 0F;
        [Required]
        public string Content { get; set; }

        // Liste des genres séléctionné par l'utilisateur
        public List<int> Genres { get; set; }

        // Liste des genres a afficher à l'utilisateur
        public IEnumerable<Genre> AllGenres { get; init;  }
    }

    public class ModifyBookModel
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Titre")]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public float Price { get; set; } = 0F;
        [Required]
        public string Content { get; set; }

        // Liste des genres séléctionné par l'utilisateur
        public List<int> Genres { get; set; }

        // Liste des genres a afficher à l'utilisateur
        public IEnumerable<Genre> AllGenres { get; init; }
    }

    public class BookController : Controller
    {
        private readonly LibraryDbContext libraryDbContext;

        public BookController(LibraryDbContext libraryDbContext)
        {
            this.libraryDbContext = libraryDbContext;
        }

        public ActionResult<IEnumerable<Book>> List( [FromQuery] int offset = 0, [FromQuery] int limit = 10, [FromQuery] List<int> genre = null)
        {
            // récupérer les livres dans la base de donées pour qu'elle puisse être affiché
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
            return View(bookList);
        }

        public ActionResult<CreateBookModel> Create(CreateBookModel book)
        {
            // Le IsValid est True uniquement si tous les champs de CreateBookModel marqués Required sont remplis
            if (ModelState.IsValid)
            {
                // Il faut intéroger la base pour récupérer l'ensemble des objets genre qui correspond aux id dans CreateBookModel.Genres
                List<Genre> genres = libraryDbContext.Genre.Where(genre => book.Genres.Contains(genre.Id)).ToList();
                // Completer la création du livre avec toute les information nécéssaire que vous aurez ajoutez, et metter la liste des gener récupéré de la base aussi
                libraryDbContext.Add(new Book() { Author = book.Author, Title = book.Title, Price = book.Price, Content = book.Content, Genres = genres });
                libraryDbContext.SaveChanges();
            }

            // Il faut interoger la base pour récupérer tous les genres, pour que l'utilisateur puisse les slécétionné
            return View(new CreateBookModel() { AllGenres = libraryDbContext.Genre.ToList() } );
        }

        public ActionResult<Book> Show(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(List));
            }
            Book book = libraryDbContext.Books.Where(book => book.Id == id).Include(book => book.Genres).First();
            return View(book);
        }

        public ActionResult Delete(int? id, string? author = null, int? genre = 0)
        {
            if(id == null)
            {
                return RedirectToAction(nameof(List));
            }
            Book bookToDelete = libraryDbContext.Books.Where(book => book.Id == id).First();
            libraryDbContext.Remove(bookToDelete);
            libraryDbContext.SaveChanges();
            if (genre != null)
            {
                return RedirectToAction(nameof(List), new { genre = genre });
            }
            if (author!=null)
            {
                return RedirectToAction(nameof(Showauteur), new {author = author});
            }
            return RedirectToAction(nameof(List));

        }

        public ActionResult<ModifyBookModel> Modify(ModifyBookModel modifiedBook = null, int? id = null)
        {
            if (id == null) return RedirectToAction(nameof(List));
            if (ModelState.IsValid)
            {
                List<Genre> genres = libraryDbContext.Genre.Where(genre => modifiedBook.Genres.Contains(genre.Id)).ToList();
                var bookToModify = libraryDbContext.Books.Include(book => book.Genres).First(b => b.Id == modifiedBook.Id);
                bookToModify.Title = modifiedBook.Title;
                bookToModify.Author = modifiedBook.Author;
                bookToModify.Price = modifiedBook.Price;
                bookToModify.Content = modifiedBook.Content;
                bookToModify.Genres.Clear();
                bookToModify.Genres = genres;
                libraryDbContext.Update(bookToModify);
                libraryDbContext.SaveChanges();
                return RedirectToAction(nameof(Show),new { id = modifiedBook.Id });
            }
            Book book = libraryDbContext.Books.Where(book => book.Id == id).Include(book => book.Genres).First();
            List<int> genreIdList= new List<int>();
            foreach (Genre genre in book.Genres)
            {
                genreIdList.Add(genre.Id);
            }
            ModifyBookModel test = new() { Id = (int)id, Author = book.Author, Title= book.Title , Price= book.Price, Content= book.Content, AllGenres = libraryDbContext.Genre.ToList(), Genres = genreIdList };
            return View(test);
        }

        public ActionResult<Book> Showauteur(string? author)
        {
            if (author == null)
            {
                return RedirectToAction(nameof(List));
            }
            var book = libraryDbContext.Books.Where(book => book.Author == author).Include(book => book.Genres).ToList();
            return View(book);
        }
    }
}
