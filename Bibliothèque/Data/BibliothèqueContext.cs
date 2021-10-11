using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bibliothèque.Models;

namespace Bibliothèque.Data
{
    public class BibliothèqueContext : DbContext
    {
        public BibliothèqueContext (DbContextOptions<BibliothèqueContext> options)
            : base(options)
        {
        }

        public DbSet<Bibliothèque.Models.Livre> Livre { get; set; }
    }
}
