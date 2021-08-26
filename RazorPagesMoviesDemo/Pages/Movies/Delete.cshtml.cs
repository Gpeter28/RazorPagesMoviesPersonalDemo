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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext _context;

        public DeleteModel(RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Moive = await _context.Moive.FindAsync(id);

            if (Moive != null)
            {
                _context.Moive.Remove(Moive);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
