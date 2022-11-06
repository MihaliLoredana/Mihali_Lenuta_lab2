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
    public class IndexModel : PageModel
    {
        private readonly Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context _context;

        public IndexModel(Mihali_Lenuta_lab2.Data.Mihali_Lenuta_lab2Context context)
        {
            _context = context;
        }

        public IList<book> book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.book != null)
            {
                book = await _context.book.ToListAsync();
            }
        }
    }
}
