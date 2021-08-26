﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMoviesDemo.Data;
using RazorPagesMoviesDemo.Models;

namespace RazorPagesMoviesDemo.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext _context;

        public EditModel(RazorPagesMoviesDemo.Data.RazorPagesMoviesDemoContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Moive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoiveExists(Moive.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MoiveExists(int id)
        {
            return _context.Moive.Any(e => e.ID == id);
        }
    }
}
