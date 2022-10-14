using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
         
        }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(name))
            {

                ViewData["NoName"] = "Registration Failed";

            }
            else
            {
              
                ViewData["NoName"] = name + " Registration Successful";

            }

        }
    }
}