using Entities.PokeAPI.Pokemon;

namespace DomainService.Contracts.PokeAPI
{
    public interface IPokemonBL
    {
        public Pokemon GetByName(string pokemonName);
    }
}
