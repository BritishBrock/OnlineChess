using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages
{
    public class IndexModel : PageModel
    {
        public string mensaje { get; set; }
        public void OnGet()
        {
            
        }
    }
}
