using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.TMDB.Movies
{
	public class Movie : BaseTMDB
	{
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }

		[JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
		public bool Adult { get; set; }

		[JsonProperty("backdrop_path", NullValueHandling = NullValueHandling.Ignore)]
		public string BackdropPath { get; set; }

		[JsonProperty("belongs_to_collection", NullValueHandling = NullValueHandling.Ignore)]
		[NotMapped]
        public object? BelongsToCollection { get; set; }

        [JsonProperty("budget", NullValueHandling = NullValueHandling.Ignore)]
        public long Budget { get; set; }

        [JsonProperty("genres", NullValueHandling = NullValueHandling.Ignore)]
        public List<Genre> Genres { get; set; }

		[JsonProperty("homepage", NullValueHandling = NullValueHandling.Ignore)]
        public string? Homepage { get; set; }

        [JsonProperty("imdb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? ImdbId { get; set; }

		[JsonProperty("original_language", NullValueHandling = NullValueHandling.Ignore)]
		public string OriginalLanguage { get; set; }

		[JsonProperty("original_title", NullValueHandling = NullValueHandling.Ignore)]
		public string OriginalTitle { get; set; }

		[JsonProperty("overview", NullValueHandling = NullValueHandling.Ignore)]
		public string Overview { get; set; }

		[JsonProperty("popularity", NullValueHandling = NullValueHandling.Ignore)]
		public double Popularity { get; set; }

		[JsonProperty("poster_path", NullValueHandling = NullValueHandling.Ignore)]
		public string PosterPath { get; set; }

        [JsonProperty("production_companies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductionCountry> ProductionCountries { get; set; }

		[JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
		public string ReleaseDate { get; set; }

		[JsonProperty("revenue", NullValueHandling = NullValueHandling.Ignore)]
		public long Revenue { get; set; }

		[JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
		public int Runtime { get; set; }

		[JsonProperty("spoken_languages", NullValueHandling = NullValueHandling.Ignore)]
		public List<SpokenLanguage> SpokenLanguages { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public string? Status { get; set; }

		[JsonProperty("tagline", NullValueHandling = NullValueHandling.Ignore)]
		public string? Tagline { get; set; }

		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }

		[JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
		public bool Video { get; set; }

		[JsonProperty("vote_average", NullValueHandling = NullValueHandling.Ignore)]
		public double VoteAverage { get; set; }

		[JsonProperty("vote_count", NullValueHandling = NullValueHandling.Ignore)]
		public int VoteCount { get; set; }

		[JsonProperty("genre_ids", NullValueHandling = NullValueHandling.Ignore)]
		[NotMapped]
		public List<int> genreIds { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string? TrailerURL { get; set; }

		public bool NowPlaying { get; set; }
		public bool TopRated { get; set; }
		public bool Upcoming { get; set; }
		public bool TrendingDay { get; set; }
		public bool TrendingWeek { get; set; }

		public List<MoviesGenres> MoviesGenres { get; set; }
		public List<MovieProductionCompany> MovieProductionCompanies { get; set; }
		public List<MovieProductionCountry> MovieProductionCountries { get; set; }
		public List<MovieSpokenLanguage> MovieSpokenLanguages { get; set; }
	}

	public class MovieUpdated
	{
		public long Id { get; set; }

		public string Title { get; set; }
	}
}
