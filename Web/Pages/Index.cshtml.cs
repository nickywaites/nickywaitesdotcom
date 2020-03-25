using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {

        [ViewData]
        public string Title { get; private set; } = "Nicky Waites - My slice of the web";

        public void OnGet()
        {

        }
    }
}
