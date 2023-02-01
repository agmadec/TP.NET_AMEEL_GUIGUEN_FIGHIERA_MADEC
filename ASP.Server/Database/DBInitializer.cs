using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASP.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASP.Server.Database
{
    public class DbInitializer
    {
        public static void Initialize(LibraryDbContext bookDbContext)
        {

            if (bookDbContext.Books.Any())
                return;

            Genre SF, Classic, Romance, Thriller;
            bookDbContext.Genre.AddRange(
                SF = new Genre() { Name = "Science-Fiction"},
                Classic = new Genre() { Name = "Classique"},
                Romance = new Genre() { Name = "Romance"},
                Thriller = new Genre() { Name = "Thriller"}
            );
            bookDbContext.SaveChanges();

            // Une fois les moèles complété Vous pouvez faire directement
            // new Book() { Author = "xxx", Name = "yyy", Price = n.nnf, Content = "ccc", Genres = new() { Romance, Thriller } }
            bookDbContext.Books.AddRange(
                new Book() { Author = "Jojo", Title = "Jojo en cavale", Content = "Jojo est en cavale. Il a fait des bétises", Genres = new() { Classic, SF } },
                new Book() { Author = "Jojo", Title = "Jojo en cabane", Price = 19.99F, Content = "Jojo est en cabane. Il a fait des bétises", Genres = new() { Classic, Romance } },
                new Book() { Author = "Jojo", Title = "Jojo en Espagne", Price = 19.99F, Content = "Jojo est en Espagne. Il a fait des bétises", Genres = new() { Classic, Romance } },
                new Book() { Author = "Jojo", Title = "Jojo en Allemagne", Price = 19.99F, Content = "Jojo est en Allemagne. Il a fait des bétises", Genres = new() { Classic, Thriller } },
                new Book() { Author = "Jojo", Title = "Jojo en Charlemagne", Price = 19.99F, Content = "Jojo est en Charlemagne. Il a fait des bétises", Genres = new() { Classic, Romance } }
            );
            // Vous pouvez initialiser la BDD ici

            bookDbContext.SaveChanges();
        }
    }
}