using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LeafletExamples.Web.Pages
{
    public class SimpleMapModel : PageModel
    {
        private readonly ILogger<SimpleMapModel> _logger;

        public SimpleMapModel(ILogger<SimpleMapModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
