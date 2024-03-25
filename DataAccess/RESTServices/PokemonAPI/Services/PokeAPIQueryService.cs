using DataAccess.Factories;
using DataAccess.RESTServices.PokemonAPI.Interfaces;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DataAccess.RESTServices.TheMovieDB.Services;
using Entities.PokeAPI;
using Entities.TMDB.Movies;
using log4net;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RESTServices.PokemonAPI.Services
{
    public class PokeAPIQueryService : IQueryServicePokeAPI
    {
        private readonly ILog logger;
        private readonly string? apiBaseUrl;
        private readonly HttpClient httpClient;

        public PokeAPIQueryService(IConfiguration apiKeysFactory)
        {
            this.apiBaseUrl = apiKeysFactory["ApiKeys:PokeAPIBaseUrl"];
            httpClient = HttpClientFactory.ConfigClient();
            this.logger = LogManager.GetLogger(typeof(TmdbQueryService));
        }

        public async Task<Pokemon> GetByName(string name)
        {
            Pokemon pokemon = new();
            var response = await httpClient.GetAsync($"{apiBaseUrl}/pokemon/pikachu/{name}");
            if (response.IsSuccessStatusCode)
            {
                string readResponseAsync = await response.Content.ReadAsStringAsync();
                pokemon = JsonConvert.DeserializeObject<Pokemon>(readResponseAsync);
            }
            return pokemon;
        }
    }
}
