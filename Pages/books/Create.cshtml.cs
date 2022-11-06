using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mihali_Lenuta_lab2.Data;
using Mihali_Lenuta_lab2.Models;

namespace Mihali_Lenuta_lab2.Pages.books
{
    public class CreateModel : PageModel
    {
        private readonly Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context _context;

        public CreateModel(Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public book book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.book.Add(book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
