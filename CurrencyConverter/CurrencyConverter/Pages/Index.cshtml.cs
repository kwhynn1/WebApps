using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public double GBP { get; set; }

        [BindProperty]
        public double EUR { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            EUR = 1.16;
            GBP = 1.0;
        }

        public void OnPost()
        {
            if (GBP == 1.0) 
            {
                ViewData["Convert"] = "The Converted Amount Is " + EUR;
            }
            else
            {
                ViewData["Convert"] = "The Converted Amount Is " + GBP * EUR;
            }

        }
    }
}