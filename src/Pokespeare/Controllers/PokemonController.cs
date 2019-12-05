using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pokespeare.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET /pokemon/name
        [HttpGet("{pokemon}")]
        public ActionResult<string> Get(string pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
