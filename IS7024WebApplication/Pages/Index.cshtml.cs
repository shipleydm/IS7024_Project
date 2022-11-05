﻿using Microsoft.AspNetCore.Mvc;
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
           /* var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string tmApiKey = config["tmApiKey"];
            ViewData["tmApiKey"] = tmApiKey;
            var task = client.GetAsync($"https://api.themoviedb.org/3/trending/movie/week?api_key={tmApiKey}");
            HttpResponseMessage result = task.Result;
            TrendingMovieModel trendingMovies = new TrendingMovieModel();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                trendingMovies = TrendingMovieModel.FromJson(jsonString);
            }
            ViewData["trendingMovies"] = trendingMovies; */
        }

        public void OnGetFormSubmit(string Movie_Title)
        {
            var task = client.GetAsync("https://www.omdbapi.com/?apikey=c4dad057&t=" + Movie_Title);
            HttpResponseMessage result = task.Result;
            var movie = new Movie();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readMovieString = result.Content.ReadAsStringAsync();
                string movieSearchResult = readMovieString.Result;
                movie = Movie.FromJson(movieSearchResult);

            }

            //streaming availability block
            var requestStreaming = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://streaming-availability.p.rapidapi.com/search/basic?country=us&service=netflix&type=movie&language=en&keyword=" + Movie_Title),
                Headers =
                {
                    { "X-RapidAPI-Key", "8306c392d2msha2f01fa02736a36p138bc7jsn920b2226f7d5" },
                    { "X-RapidAPI-Host", "streaming-availability.p.rapidapi.com" },
                },
            };

            var StreamingTask = client.SendAsync(requestStreaming);
            HttpResponseMessage StreamingResult = StreamingTask.Result;
            var streamingavailability = new StreamingAvailability();
            if (StreamingResult.IsSuccessStatusCode)
            {
                Task<string> StreamingReadMovieString = StreamingResult.Content.ReadAsStringAsync();
                string StreamingMovieSearchResult = StreamingReadMovieString.Result;
                streamingavailability = StreamingAvailability.FromJson(StreamingMovieSearchResult);

            }

            // tempdata is needed to store and pass the data to another cshtml UI page
            TempData.Put("Movie", movie);
            TempData.Put("StreamingAvailability", streamingavailability);

            // redirecting to show search results in their own page
            Response.Redirect("/SeeMovieDetails");
        }
    }
}