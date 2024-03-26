using Entities.PokeAPI.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RESTServices.PokemonAPI.Interfaces
{
    public interface IQueryServicePokeAPI
    {
        public Task<Pokemon> GetByName(string name);
    }
}
