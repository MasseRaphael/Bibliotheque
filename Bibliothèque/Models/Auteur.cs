using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliothèque.Models
{
    public class Auteur
    {
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
        [Required]
        public string Nom { get; set; }
    }
}
