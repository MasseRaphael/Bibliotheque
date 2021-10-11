using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliothèque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliothèque.Models
{
    public static class SeedData3
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (BibliothèqueContext context = new BibliothèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BibliothèqueContext>>()))
            {
                
                if (context.Genre.Any())
                {
                    return;   
                }

                context.Genre.AddRange(
                    new Genre
                    {
                        Genres = "Fantaisie"
                    },

                    new Genre
                    {
                        Genres = "Policier"
                    },

                    new Genre
                    {
                        Genres = "Science Fiction"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
