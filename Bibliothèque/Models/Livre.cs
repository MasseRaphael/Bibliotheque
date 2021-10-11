using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliothèque.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int TomeNum { get; set; }
        public string TitreSerie { get; set; }
    }
}
