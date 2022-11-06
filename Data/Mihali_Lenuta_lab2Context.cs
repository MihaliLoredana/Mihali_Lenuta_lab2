using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihali_Lenuta_lab2.Models;

namespace Mihali_Lenuta_lab2.Data
{
    public class Mihali_Lenuta_lab2Context : DbContext
    {
        public Mihali_Lenuta_lab2Context (DbContextOptions<Mihali_Lenuta_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mihali_Lenuta_lab2.Models.book> book { get; set; } = default!;
    }
}
