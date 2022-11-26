namespace IS7024WebApplication
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ChefAuthor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("favoriteRecipe")]
        public string FavoriteRecipe { get; set; }
    }

    public partial class ChefAuthor
    {
        public static List<ChefAuthor> FromJson(string json) => JsonConvert.DeserializeObject<List<ChefAuthor>>(json, IS7024WebApplication.Converter.Settings);
    }
 
}

