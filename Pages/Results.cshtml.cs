using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SearchEngine.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly ILogger<ResultsModel> _logger;

        [BindProperty(Name="Query", SupportsGet = true)]
        public string Query { get; set; }

        public ResultsModel(ILogger<ResultsModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string query)
        {
            Query = query;
           // Fetch Search Results
            return Page();
        }
    }
}