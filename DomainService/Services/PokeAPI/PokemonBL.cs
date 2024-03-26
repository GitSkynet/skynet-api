using DataAccess.RESTServices.PokemonAPI.Interfaces;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.PokeAPI;
using DomainService.Services.BaseBL;
using Entities.PokeAPI.Pokemon;
using Repository.Contracts.PokeAPI;

namespace DomainService.Services.PokeAPI
{
    public class PokemonBL : BaseBL<Pokemon>, IPokemonBL
    {
        private readonly IQueryServicePokeAPI queryService;
        private readonly IPokemonDA pokemonDA;
        public PokemonBL(IQueryServicePokeAPI iQueryService, IPokemonDA ipokemonDA) : base((Repositories.BaseDA.IBaseDA<Pokemon>)ipokemonDA)
        {
            pokemonDA = ipokemonDA;
            queryService = iQueryService;
        }

        // public Pokemon GetByName(string pokemonName) => pokemonDA.GetByName(pokemonName);
        
        public Pokemon GetByName(string pokemonName)
        {
            Pokemon pokemon = queryService.GetByName("Pikachu").Result;

            return pokemon;
        }
    }
}
