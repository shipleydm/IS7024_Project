using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IS7024WebApplication.Pages
{
    public class ChefAuthorsModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();

        private readonly ILogger<ChefAuthorsModel> _logger;

        public ChefAuthorsModel(ILogger<ChefAuthorsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var task = client.GetAsync("https://uchef20221121194020.azurewebsites.net/chefauthors");
            HttpResponseMessage result = task.Result;
            List<ChefAuthor> chefAuthors = new List<ChefAuthor>();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                chefAuthors = ChefAuthor.FromJson(jsonString);
            }
            ViewData["chefAuthors"] = chefAuthors;
        }
    }
}
