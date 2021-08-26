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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext _context;

        public DetailsModel(RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext context)
        {
            _context = context;
        }

        public Moive Moive { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Moive = await _context.Moive.FirstOrDefaultAsync(m => m.ID == id);

            if (Moive == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
