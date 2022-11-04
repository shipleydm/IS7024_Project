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

                    public void OnGetFormSubmit(string Movie_Title)
        {
            var taskStreaming = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://streaming-availability.p.rapidapi.com/search/basic?country=us&service=netflix&type=movie&language=en&keyword=" + Movie_Title),
                Headers =
                {
                    { "X-RapidAPI-Key", "8306c392d2msha2f01fa02736a36p138bc7jsn920b2226f7d5" },
                    { "X-RapidAPI-Host", "streaming-availability.p.rapidapi.com" },
                },
            };
            var streamingavailability = new StreamingAvailability();
            //TempData.Put("movie", streamingavailability);
            client.SendAsync(StreamingAvailability).Wait();
            Response.Redirect("/");

        }


        }
    }
}