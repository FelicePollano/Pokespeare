using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokespeare.Common;

namespace Pokespeare.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        readonly ILogger<PokemonController> logger;
        readonly IPokemonInfoProvider provider;
        public PokemonController(ILogger<PokemonController> logger,IPokemonInfoProvider provider)
        {
            this.logger = logger;
            this.provider = provider;
        }
       
        // GET /pokemon/name
        [HttpGet("{pokemon}")]
        public async Task<string> Get(string pokemon)
        {
            logger.LogInformation("Retrieving Pokemon informations");
            return await provider.GetDescriptionAsync(pokemon);
        }
    }
}
