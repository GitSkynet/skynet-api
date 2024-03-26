using DataContext.DbContexts.PokemonDbContext;
using DataContext.DbContexts.TmdbDbContext;
using Entities.PokeAPI.Pokemon;
using Microsoft.EntityFrameworkCore;
using Repositories.BaseDA;
using Repository.Contracts.PokeAPI;

namespace Repositories.PokemonRepo
{
    public class PokemonDA : BaseDA<Pokemon>, IPokemonDA
    {
        private readonly PokemonDbContext dbContext;

        public PokemonDA(PokemonDbContext context) : base(context)
        {
            dbContext = context;
        }

        public Pokemon GetByName(string pokemonName)
        {
            return new Pokemon();
        }
    }
}
