using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliothèque.Controllers
{
    public class LivreController : Controller
    {
        //
        // GET: /Livre/
        public IActionResult Index()
        {
            return View();
        }
    }
}
