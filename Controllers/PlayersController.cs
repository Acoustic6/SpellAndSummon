using Microsoft.AspNetCore.Mvc;
using SpellAndSummon.Models;

namespace SpellAndSummon.Controllers
{
    [Route("/api/players")]
    public class PlayersController : Controller
    {
        [HttpPost]
        public IActionResult CreatePlayer([FromBody]Player player)
        {
            return Ok(player);
        }
    }
}