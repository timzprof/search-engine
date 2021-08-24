using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SearchEngine.Pages
{
    public class UploadModel : PageModel
    {
        private readonly ILogger<UploadModel> _logger;

        public UploadModel(ILogger<UploadModel> logger)
        {
            _logger = logger;
        }
    }
}