using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliothèque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliothèque.Models
{
    public static class SeedData6
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (BibliothèqueContext context = new BibliothèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BibliothèqueContext>>()))
            {
                
                if (context.Type.Any())
                {
                    return;   
                }

                context.Type.AddRange(
                    new Type
                    {
                        Types = "Roman"
                    },

                    new Type
                    {
                       Types = "Nouvelle"
                    },

                    new Type
                    {
                        Types = "Mangas"
                    },

                    new Type
                    {
                        Types = "Bande Dessinée"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
