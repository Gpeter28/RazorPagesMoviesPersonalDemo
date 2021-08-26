using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviesDemo.Data;
using RazorPagesMoviesDemo.Models;

namespace RazorPagesMoviesDemo.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext _context;

        public IndexModel(RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext context)
        {
            _context = context;
        }

        public IList<Moive> Moive { get;set; }

        public async Task OnGetAsync()
        {
            Moive = await _context.Moive.ToListAsync();
        }
    }
}
