using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppYN.Pages
{
    public class BlogPost : PageModel
    {
        private readonly ILogger<BlogPost> _logger;

        public BlogPost(ILogger<BlogPost> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
