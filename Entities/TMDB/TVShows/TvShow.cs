using Entities.Base;
using Entities.TMDB.Movies;
using Newtonsoft.Json;

namespace Entities.TMDB.TVShows
{
    public class TvShow : EntityBase
    {
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public int Id { get; set; }

		[JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
		public bool Adult { get; set; }

		[JsonProperty("backdrop_path", NullValueHandling = NullValueHandling.Ignore)]
		public string BackdropPath { get; set; }

		[JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreatedBy> CreatedBy { get; set; }

        [JsonProperty("episode_run_time", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> EpisodeRunTime { get; set; }

        [JsonProperty("first_air_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstAirDate { get; set; }

        [JsonProperty("genres", NullValueHandling = NullValueHandling.Ignore)]
        public List<Genre> Genres { get; set; }

        [JsonProperty("genre_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> GenreIds { get; set; }

        [JsonProperty("homepage", NullValueHandling = NullValueHandling.Ignore)]
        public string Homepage { get; set; }

        [JsonProperty("in_production", NullValueHandling = NullValueHandling.Ignore)]
        public bool InProduction { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Languages { get; set; }

        [JsonProperty("last_air_date", NullValueHandling = NullValueHandling.Ignore)]
        public string LastAirDate { get; set; }

        [JsonProperty("last_episode_to_air", NullValueHandling = NullValueHandling.Ignore)]
        public LastEpisodeToAir LastEpisodeToAir { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("next_episode_to_air", NullValueHandling = NullValueHandling.Ignore)]
        public object NextEpisodeToAir { get; set; }

        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Network> Networks { get; set; }

        [JsonProperty("number_of_episodes", NullValueHandling = NullValueHandling.Ignore)]
        public int NumberOfEpisodes { get; set; }

        [JsonProperty("number_of_seasons", NullValueHandling = NullValueHandling.Ignore)]
        public int NumberOfSeasons { get; set; }

        [JsonProperty("origin_country", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OriginCountry { get; set; }

        [JsonProperty("original_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalName { get; set; }

        [JsonProperty("production_companies", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("seasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Season> Seasons { get; set; }

        [JsonProperty("spoken_languages", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpokenLanguage> SpokenLanguages { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("tagline", NullValueHandling = NullValueHandling.Ignore)]
        public string Tagline { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

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

		[JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
		public string ReleaseDate { get; set; }

		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }

		[JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
		public bool Video { get; set; }

		[JsonProperty("vote_average", NullValueHandling = NullValueHandling.Ignore)]
		public double VoteAverage { get; set; }

		[JsonProperty("vote_count", NullValueHandling = NullValueHandling.Ignore)]
		public int VoteCount { get; set; }
	}
}
