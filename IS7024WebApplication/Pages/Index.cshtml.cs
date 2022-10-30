using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Reflection;

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
        }

        public void OnGetFormSubmit(string Movie_Title)
        {
            var task = client.GetAsync("https://www.omdbapi.com/?apikey=c4dad057&t=" + Movie_Title);
            HttpResponseMessage result = task.Result;
            var movie = new Movie();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                movie = Movie.FromJson(jsonString);

            }

            /*ViewData["Movie"] = movie;*/
            TempData.Put("Movie", movie);
            Response.Redirect("/SeeMovieDetails");
        }
    }
}