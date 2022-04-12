using Microsoft.EntityFrameworkCore;
using MovieDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDotNetCore.DAL.Data
{
    class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
        public DbSet<MovieDetails> movieDetails { get; set; }
    }
}