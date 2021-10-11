﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliothèque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliothèque.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BibliothèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BibliothèqueContext>>()))
            {
                // Look for any movies.
                if (context.Livre.Any())
                {
                    return;   // DB has been seeded
                }

                context.Livre.AddRange(
                    new Livre
                    {
                        Titre = "Frère de Loup",
                        TomeNum = 1,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    },

                    new Livre
                    {
                        Titre = "Fils de l'Eau",
                        TomeNum = 2,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    },

                    new Livre
                    {
                        Titre = "Les Mangeurs d'Ames",
                        TomeNum = 3,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    },

                    new Livre
                    {
                        Titre = "Le Banni",
                        TomeNum = 4,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    },
                    new Livre
                    {
                        Titre = "Le Serment",
                        TomeNum = 5,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    },
                    new Livre
                    {
                        Titre = "Chasseur de Fantômes",
                        TomeNum = 6,
                        TitreSerie = "Chroniques des Temps Obscurs"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
