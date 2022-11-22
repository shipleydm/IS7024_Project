using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WatchNowAPI
{
    public partial class TrendingMovieModel
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("results")]
        public List<MovieResult> Results { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }

    public partial class MovieResult
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackDropPath { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("original_language")]
        public OriginalLanguage OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        [JsonProperty("genre_ids")]
        public List<long> GenreIds { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }
    }

    public enum MediaType { Movie, All, Tv, Person };

    public enum OriginalLanguage { bi, cs, ba, ae, av, de, mt, om, rm, so, ts, vi, gn, ig, it, ki, ku, la, ln, lb, ny, pl, si, to, az, ce, cu, da, hz, ie, rw, mi, no, pi, sk, se, sm, uk, en, ay, ca, eo, ha, ho, hu, io, ii, kn, kv, li, oj, ru, sr, sv, ty, zu, ka, ch, be, br, kw, fi, sh, nn, tt, tg, vo, ps, mk, fr, bm, eu, fj, id, mg, na, xx, qu, sq, ti, tw, wa, ab, bs, af, an, fy, gu, ik, ja, ko, lg, nl, os, el, bn, cr, km, lo, nd, ne, sc, sw, tl, ur, ee, aa, co, et, ks, kr, ky, kj, nr, or, wo, za, ar, cv, fo, hr, ms, nb, rn, sn, st, tr, am, fa, hy, pa, ia, lv, lu, mr, mn, pt, th, tk, ve, dv, gv, kl, kk, lt, my, sl, sd, cn, hi, cy, ht, iu, jv, mh, sa, ss, te, kg, ml, uz, sg, xh, es, su, ug, yi, yo, zh, he, bo, ak, mo, ng, dz, ff, gd, ga, gl, nv, oc, ro, ta, tn, bg };

    public partial class TrendingMovieModel
    {
        public static TrendingMovieModel FromJson(string json) => JsonConvert.DeserializeObject<TrendingMovieModel>(json, WatchNowAPI.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    internal class MediaTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MediaType) || t == typeof(MediaType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MediaType)untypedValue;

            throw new Exception("Cannot marshal type MediaType");
        }

        public static readonly MediaTypeConverter Singleton = new MediaTypeConverter();
    }

    internal class OriginalLanguageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OriginalLanguage) || t == typeof(OriginalLanguage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OriginalLanguage)untypedValue;
            throw new Exception("Cannot marshal type OriginalLanguage");
        }

        public static readonly OriginalLanguageConverter Singleton = new OriginalLanguageConverter();
    }
}
