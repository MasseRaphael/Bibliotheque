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
        public DbSet<Bibliothèque.Models.Note> Note { get; set; }
        public DbSet<Bibliothèque.Models.Genre> Genre { get; set; }
        public DbSet<Bibliothèque.Models.Type> Type { get; set; }
        public DbSet<Bibliothèque.Models.Auteur> Auteur { get; set; }
        public DbSet<Bibliothèque.Models.Statut> Statut { get; set; }
    }
}
