using System;
using System.Collections.Generic;
using BCCMovieChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace BCCMovieChallenge.Data
{
    public class ApplicationDbContext : DbContext
    {
        public string DbPath { get; set; }

        public ApplicationDbContext()
        {
            // Have to use double slashes here because escape sequences
            DbPath = "c:\\Users\\manvelt\\Documents\\BCC\\MovieDB.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(p => new { p.Id });
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
