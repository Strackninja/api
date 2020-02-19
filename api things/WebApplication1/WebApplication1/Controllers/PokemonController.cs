using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 67},
            new Pokemon() {Name = "Bulbasaur", Strength = 200},
            new Pokemon() {Name = "arts", Strength = 9874},
        };

        [HttpGet]
        public ActionResult Get()
        {
            //Pokemon p = new Pokemon();
            //p.Name = "Ekans";
            //p.Strength = 67;

            return Ok(pokemons);
        }



    }
}
