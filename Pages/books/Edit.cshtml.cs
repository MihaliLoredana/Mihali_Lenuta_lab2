﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mihali_Lenuta_lab2.Data;
using Mihali_Lenuta_lab2.Models;

namespace Mihali_Lenuta_lab2.Pages.books
{
    public class EditModel : PageModel
    {
        private readonly Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context _context;

        public EditModel(Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public book book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }

            var book =  await _context.book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            book = book;
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

            _context.Attach(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!bookExists(book.ID))
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

        private bool bookExists(int id)
        {
          return _context.book.Any(e => e.ID == id);
        }
    }
}
