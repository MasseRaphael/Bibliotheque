using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliothèque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliothèque.Models
{
    public static class SeedData4
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (BibliothèqueContext context = new BibliothèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BibliothèqueContext>>()))
            {
                
                if (context.Note.Any())
                {
                    return;   
                }

                context.Note.AddRange(
                    new Note
                    {
                        Notes = 1
                    },

                    new Note
                    {
                        Notes = 2
                    },

                    new Note
                    {
                        Notes = 3
                    },

                    new Note
                    {
                        Notes = 4
                    },
                    new Note
                    {
                        Notes = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
