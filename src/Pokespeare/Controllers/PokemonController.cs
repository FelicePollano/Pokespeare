using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pokespeare.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        readonly ILogger<PokemonController> logger;
        public PokemonController(ILogger<PokemonController> logger)
        {
            this.logger = logger;
        }
       
        // GET /pokemon/name
        [HttpGet("{pokemon}")]
        public ActionResult<string> Get(string pokemon)
        {
            logger.LogInformation("Retrieving Pokemon informations");
            return "nothing";
        }
    }
}
