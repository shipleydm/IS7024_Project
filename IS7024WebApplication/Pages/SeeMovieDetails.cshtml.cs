using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace IS7024WebApplication.Pages
{
    public class SeeMovieDetailsModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<SeeMovieDetailsModel> _logger;

    }
}
