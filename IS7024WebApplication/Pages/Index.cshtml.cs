using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IS7024WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var task = client.GetAsync("https://www.omdbapi.com/?apikey=c4dad057&t=the%20batman");
            HttpResponseMessage result = task.Result;
            var movie = new Movie();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                movie = Movie.FromJson(jsonString);

            }
            ViewData["Movie"] = movie;



        }
    }
}