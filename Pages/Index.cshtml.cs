using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SearchEngine.Models;

namespace SearchEngine.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost([FromForm]string query)    
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Redirect("/Results?query=" + query);
        }

        public IActionResult Rediect() {
            return RedirectToPage("./Results");
        }
    }
}
