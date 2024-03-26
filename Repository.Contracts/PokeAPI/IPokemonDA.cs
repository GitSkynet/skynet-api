using Entities.PokeAPI.Pokemon;

namespace Repository.Contracts.PokeAPI
{
    public interface IPokemonDA
    {
        /// <summary>
        /// Obtiene el Pokémon por el ID especificado
        /// </summary>
        /// <param name="pekemonID">Identificador del Pokémon a buscar</param>
        /// <returns>Un objeto de tipo <see cref="Pokemon"/> con el Pokémon requerido</returns>
        Pokemon GetById(long pokemonId);

        /// <summary>
        /// Obtiene el Pokémon por el nombre especificado
        /// </summary>
        /// <param name="pokemonName">Nombre del Pokémon a buscar</param>
        /// <returns>Un objeto de tipo <see cref="Pokemon"/> con el Pokémon requerido</returns>
        Pokemon GetByName(string pokemonName);
    }
}
