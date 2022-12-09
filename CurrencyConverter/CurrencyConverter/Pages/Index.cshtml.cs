using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public double JMD { get; set; }

        [BindProperty]
        public double USD { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            USD = 1.16;
            JMD = 1.0;
        }

        public void OnPost()
        {
            if (JMD == 1.0) 
            {
                ViewData["Convert"] = "The converted amount is $" + USD + " in USD";
            }
            else
            {
                ViewData["Convert"] = "The converted amount is $" + JMD * USD + " in USD";
            }

        }
    }
}