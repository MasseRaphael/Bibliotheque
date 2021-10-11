using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliothèque.Models
{
    public class Livre
    {
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Titre { get; set; }
        [Required]
        public int TomeNum { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string TitreSerie { get; set; }
        [Required]
        public int NomPages { get; set; }
    }
}
