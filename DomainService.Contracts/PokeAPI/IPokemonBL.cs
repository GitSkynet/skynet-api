using Entities.PokeAPI;

namespace DomainService.Contracts.PokeAPI
{
    public interface IPokemonBL
    {
        public Pokemon GetByName(string pokemonName);
    }
}
