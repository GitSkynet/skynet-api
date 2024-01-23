using Newtonsoft.Json;

namespace Entities.TMDB.Movies
{
    public class DatesResult
    {
		[JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
		public string DateMaximum { get; set; }
		
        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public string DateMinimum { get; set; }
    }

	public class ResponseUpcomingMovies
	{
		[JsonProperty("dates", NullValueHandling = NullValueHandling.Ignore)]
		public DatesResult Dates { get; set; }

		[JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
		public string? Page { get; set; }

		[JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
		public List<Movie>? MoviesList { get; set; }

		[JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
		public long TotalPages { get; set; }

		[JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
		public long TotalResults { get; set; }
	}

	public class ResponseHandlerMovies
    {
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string? Page { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Movie>? MoviesList { get; set; }

        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPages { get; set; }

        [JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalResults { get; set; }
    }
    
    public class ResponseChangeMovies
    {
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<MovieIdChange>? MoviesList { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string? Page { get; set; }

        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalPages { get; set; }

        [JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public long TotalResults { get; set; }
    }

    public class MovieIdChange
    {
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public long Id { get; set; }

		[JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
        public string Adult { get; set; }
    }
}
