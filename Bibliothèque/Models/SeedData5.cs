using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliothèque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliothèque.Models
{
    public static class SeedData5
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (BibliothèqueContext context = new BibliothèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BibliothèqueContext>>()))
            {
                
                if (context.Statut.Any())
                {
                    return;   
                }

                context.Statut.AddRange(
                    new Statut
                    {
                        Statuts = "Terminé"
                    },

                    new Statut
                    {
                        Statuts = "En Cours"
                    },

                    new Statut
                    {
                        Statuts = "Pas lu"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
