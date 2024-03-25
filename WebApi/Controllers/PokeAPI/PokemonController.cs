using DomainService.Contracts.PokeAPI;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.PokeAPI
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : Controller
    {
        private readonly IPokemonBL pokemonBL;

        public PokemonController(IPokemonBL iPokemonBL)
        {
            pokemonBL = iPokemonBL;
        }

        [HttpGet]
        [Route("get_by_name")]
        public IActionResult GetByName(string pokemonName)
            => new ObjectResult(pokemonBL.GetByName(pokemonName));
    }
}
