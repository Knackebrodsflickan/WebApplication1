using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemon")]
    public class PokemonController : Controller
    {
        [HttpGet]
        public ActionResult MyPerfectGet()
        {
            return Ok("Hello");
        }

        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strenght = 67}
        };


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons);
        }


        [HttpPost]
        public ActionResult Post(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine("Added " + newPokemon.Name);



            return Created("", newPokemon);
        }

    }
}