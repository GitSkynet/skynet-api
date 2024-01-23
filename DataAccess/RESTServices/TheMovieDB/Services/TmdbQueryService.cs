using DataAccess.Factories;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using Entities.TMDB;
using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;
using log4net;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataAccess.RESTServices.TheMovieDB.Services
{
    public class TmdbQueryService : IQueryServiceTMDB
    {
        private readonly ILog logger;
        private readonly string? tmdbApiKey;
        private readonly string? tmdbBaseUrl;
        private readonly HttpClient httpClient;

        public TmdbQueryService(IConfiguration apiKeysFactory) 
        {
            this.tmdbApiKey = apiKeysFactory["ApiKeys:Tmdb"];
            this.tmdbBaseUrl = apiKeysFactory["ApiKeys:TmdbBaseUrl"];
            httpClient = HttpClientFactory.ConfigClient();
            this.logger = LogManager.GetLogger(typeof(TmdbQueryService));
        }

        public async Task<Movie> GetByID(long movieID, string language)
        {
            Movie theMovie = new ();
            var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/{movieID}?api_key={tmdbApiKey}&language={language}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                theMovie = JsonConvert.DeserializeObject<Movie>(readResponseAsync);
            }
            return theMovie;
        }

        public async Task<TvShow> GetTvShowById(long tvShowID, string language)
        {
            TvShow tvShow = new();
            var response = await httpClient.GetAsync($"{tmdbBaseUrl}/tv/{tvShowID}?api_key={tmdbApiKey}&language={language}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                tvShow = JsonConvert.DeserializeObject<TvShow>(readResponseAsync);
            }
            else
            {
                throw new Exception(string.Concat("API Error: ", response.StatusCode.ToString()));
            }
            return tvShow;
        }

        public async Task<List<Movie>> GetMostPopularMovies(string page)
        {
            ResponseHandlerMovies listPopularMovies = new ();
            var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/popular?api_key={tmdbApiKey}&language=es&page={page}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                listPopularMovies = JsonConvert.DeserializeObject<ResponseHandlerMovies>(readResponseAsync);
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return listPopularMovies.MoviesList;
        }
        
        public async Task<List<Movie>> GetNowPlayingMovies(string page)
        {
			ResponseUpcomingMovies listNowPlayingMovies = new ();
			var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/now_playing?api_key={tmdbApiKey}&language=es&page={page}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
				listNowPlayingMovies = JsonConvert.DeserializeObject<ResponseUpcomingMovies>(readResponseAsync);
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return listNowPlayingMovies.MoviesList;
        }
        
        public async Task<List<Movie>> GetUpcomingMovies(string page)
        {
			ResponseUpcomingMovies listUpcomingMovies = new ();
			var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/upcoming?api_key={tmdbApiKey}&language=es&page={page}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
				listUpcomingMovies = JsonConvert.DeserializeObject<ResponseUpcomingMovies>(readResponseAsync);
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return listUpcomingMovies.MoviesList;
        }
        
        public async Task<List<TvShow>> GetMostPopularTvShows(string language, string page)
        {
            ResponseHandlerTvShows listPopularTvShows = new ();
            var response = await httpClient.GetAsync($"{tmdbBaseUrl}/tv/popular?api_key={tmdbApiKey}&language={language}&page={page}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                listPopularTvShows = JsonConvert.DeserializeObject<ResponseHandlerTvShows>(readResponseAsync);
            }
            else
            {
                throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
            }
            return listPopularTvShows.TvShowsList;
        }

        public async Task<List<Movie>> GetMostRecentMovies(string language, string page)
        {
            try
            {
                ResponseHandlerMovies listPopularMovies = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/now_playing?api_key={tmdbApiKey}&language=es-ES&page=1");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
                    listPopularMovies = JsonConvert.DeserializeObject<ResponseHandlerMovies>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listPopularMovies.MoviesList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error mostRecent endpoint: {ex}");
            }
        }

        public async Task<List<TvShow>> GetMostRecentTvShows(string language, string page)
        {
            try
            {
                ResponseHandlerTvShows listPopularTvShows = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/tv/on_the_air?api_key={tmdbApiKey}&language={language}&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
                    listPopularTvShows = JsonConvert.DeserializeObject<ResponseHandlerTvShows>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listPopularTvShows.TvShowsList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error mostRecent endpoint: {ex}");
            }
        }

        public async Task<List<Movie>> GetMoviesByGenre(string genre, string page, bool adult=false)
        {
            try
            {
                ResponseHandlerMovies listPopularMovies = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/discover/movie?api_key={tmdbApiKey}&sort_by=popularity.desc&with_genres={genre}&page={page}&language=es");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
                    listPopularMovies = JsonConvert.DeserializeObject<ResponseHandlerMovies>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listPopularMovies.MoviesList;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error mostRecent endpoint: {ex}");
            }
        }
        
        public async Task<List<TvShow>> GetTvShowsByCategory(string category, string language, string page)
        {
            try
            {
                ResponseHandlerTvShows listTvShows = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/discover/tv?api_key={tmdbApiKey}&language={language}&sort_by=popularity.desc&with_genres={category}&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
                    listTvShows = JsonConvert.DeserializeObject<ResponseHandlerTvShows>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listTvShows.TvShowsList;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error mostRecent endpoint: {ex}");
            }
        }

        public async Task<List<Movie>> GetTrendingDay(string page)
        {
            try
            {
				ResponseUpcomingMovies listTrendingMovies = new();
				var response = await httpClient.GetAsync($"{tmdbBaseUrl}/trending/movie/day?api_key={tmdbApiKey}&language=es&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
					listTrendingMovies = JsonConvert.DeserializeObject<ResponseUpcomingMovies>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listTrendingMovies.MoviesList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error GetTrending endpoint: {ex}");
            }
        }
        
        public async Task<List<Movie>> GetTrendingWeek(string page)
        {
            try
            {
				ResponseUpcomingMovies listTrendingMovies = new();
				var response = await httpClient.GetAsync($"{tmdbBaseUrl}/trending/movie/week?api_key={tmdbApiKey}&language=es&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
					listTrendingMovies = JsonConvert.DeserializeObject<ResponseUpcomingMovies>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listTrendingMovies.MoviesList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error GetTrending endpoint: {ex}");
            }
        }
        
        public async Task<List<Movie>> GetTopRated(string page)
        {
            try
            {
				ResponseUpcomingMovies listTrendingMovies = new();
				var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/top_rated?api_key={tmdbApiKey}&language=es-ES&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
					listTrendingMovies = JsonConvert.DeserializeObject<ResponseUpcomingMovies>(readResponseAsync);
                }
                else
                {
                    throw new Exception(string.Concat("Error with StatusCode: ", response.StatusCode.ToString()));
                }
                return listTrendingMovies.MoviesList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error GetTrending endpoint: {ex}");
            }
        }

        public async Task<string> GetMovieTrailer(long movieId, string language)
        {
            try
            {
                var trailerURL = "";
                TrailerResponse listPopularMovies = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/{movieId}/videos?api_key={tmdbApiKey}&language={language}");
                if (response.IsSuccessStatusCode)
                {
                    string readResponseAsync = await response.Content.ReadAsStringAsync();
                    var videos = JsonConvert.DeserializeObject<TrailerResponse>(readResponseAsync);
                    if (videos?.Results.Count > 0)
                    {
                        var trailerKey = videos.Results.FirstOrDefault(v => v.Type == "Trailer")?.Key;
                        if (!string.IsNullOrEmpty(trailerKey))
                        {
                            trailerURL = $"https://www.youtube.com/watch?v={trailerKey}";
                        }
                    }
                }
                return trailerURL;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error mostRecent endpoint: {ex}");
            }
        }

        public async Task<List<ProductionCountry>> GetProductionCountries()
        {
			try
			{
				List<ProductionCountry> listCountries = new();
				var response = await httpClient.GetAsync($"{tmdbBaseUrl}/configuration/countries?language=es&api_key={tmdbApiKey}");
				
                if (response.IsSuccessStatusCode)
				{
					string readResponseAsync = await response.Content.ReadAsStringAsync();
					List<CountriesTMDB> listCountriesTMDB = JsonConvert.DeserializeObject<List<CountriesTMDB>>(readResponseAsync)!;
					listCountries = listCountriesTMDB
						.Select(x => new ProductionCountry
						{
							Id = x.Id,
							Iso31661 = x.Iso31661,
							Name = x.Name
						})
						.ToList();
				}
                else
                {
					throw new Exception(string.Concat("GetProductionCountries error: ", response.StatusCode.ToString()));
				}
				return listCountries;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error GetProductionCountries endpoint: {ex}");
			}
		}

		public async Task<List<SpokenLanguage>> GetSpokenLanguages()
		{
			try
			{
				List<SpokenLanguage> listSpkLang = new();
				var response = await httpClient.GetAsync($"{tmdbBaseUrl}/configuration/languages?language=es&api_key={tmdbApiKey}");

				if (response.IsSuccessStatusCode)
				{
					string readResponseAsync = await response.Content.ReadAsStringAsync();
					listSpkLang = JsonConvert.DeserializeObject<List<SpokenLanguage>>(readResponseAsync)!;
				}
				else
				{
					throw new Exception(string.Concat("GetSpokenLanguages error: ", response.StatusCode.ToString()));
				}
				return listSpkLang;
			}
			catch (Exception ex)
			{
				throw new Exception($"{ex}");
			}
		}

        public async Task<List<Genre>> GetGenres()
        {
            try
            {
                List<Genre> genres = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/genre/movie/list?language=es&api_key={tmdbApiKey}");

                if (response.IsSuccessStatusCode)
                {
                    string readAsync = await response.Content.ReadAsStringAsync();
					var genresOnTmdb = JsonConvert.DeserializeObject<List<Genre>>(JObject.Parse(readAsync)["genres"].ToString())!;
					genres = genresOnTmdb
						.Select(genre => new Genre
		                {
			                IdTMDB = genre.Id,
			                Name = genre.Name
		                })
		                .ToList();
				}
                else
                {
                    throw new Exception(string.Concat("GetGenre error: ", response.StatusCode.ToString()));
                }
                return genres;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
        }
        
        public async Task<ResponseChangeMovies> GetMoviesChanged(string page)
        {
            try
            {
				ResponseChangeMovies moviesChanged = new();
                var response = await httpClient.GetAsync($"{tmdbBaseUrl}/movie/changes?language=es&api_key={tmdbApiKey}&page={page}");
                if (response.IsSuccessStatusCode)
                {
                    string readAsync = await response.Content.ReadAsStringAsync();
					moviesChanged = JsonConvert.DeserializeObject<ResponseChangeMovies>(readAsync)!;
                    moviesChanged.MoviesList = moviesChanged.MoviesList?.Where(x => x.Id != 0 && x.Adult != null).ToList();
				}
                else
                {
                    throw new Exception(string.Concat("GetGenre error: ", response.StatusCode.ToString()));
                }
                moviesChanged.MoviesList.Take(2);

				return moviesChanged;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
        }


    }
}
