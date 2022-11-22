using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace WatchNowAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrendingMoviesController : Controller
    {

        private readonly ILogger<TrendingMoviesController> _logger;

        public TrendingMoviesController(ILogger<TrendingMoviesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTrendingMovies")]
        public TrendingMovieModel Get()
        {
            HttpClient client = new HttpClient();
            var task = client.GetAsync($"https://api.themoviedb.org/3/trending/movie/week?api_key=641404d7aea85802758ccd6b0857f41a");
            HttpResponseMessage result = task.Result;
            TrendingMovieModel trendingMovies = new TrendingMovieModel();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;

                // validation
                JSchema movieSchema = JSchema.Parse(System.IO.File.ReadAllText("Schemas/trending-movies-schema.json"));
                JObject jsonObject = JObject.Parse(jsonString);
                IList<string> validationEvents = new List<string>();
                if (jsonObject.IsValid(movieSchema, out validationEvents))
                {
                    trendingMovies = TrendingMovieModel.FromJson(jsonString);
                }
                else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                }
            }

            return trendingMovies;
        }
    }
}
