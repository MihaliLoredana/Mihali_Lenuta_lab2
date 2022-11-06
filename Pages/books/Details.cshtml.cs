using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Lenuta_lab2.Data;
using Mihali_Lenuta_lab2.Models;

namespace Mihali_Lenuta_lab2.Pages.books
{
    public class DetailsModel : PageModel
    {
        private readonly Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context _context;

        public DetailsModel(Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context context)
        {
            _context = context;
        }

      public book book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }

            var book = await _context.book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                book = book;
            }
            return Page();
        }
    }
}
