﻿using ASP.Server.Model;
using Microsoft.EntityFrameworkCore;

namespace ASP.Server.Database
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genre { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Genre>().ToTable("Genre");
        }
    }
}