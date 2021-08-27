using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMoviesDemo.Data;
using RazorPagesMoviesDemo.Models;

namespace RazorPagesMoviesDemo.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext _context;

        public CreateModel(RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Moive.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
