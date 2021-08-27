using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviesDemo.Models;

namespace RazorPagesMoviesDemo.Data
{
    public class RazorPagesMoviesDemoContext : DbContext
    {
        public RazorPagesMoviesDemoContext (DbContextOptions<RazorPagesMoviesDemoContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMoviesDemo.Models.Movie> Moive { get; set; }
    }
}
