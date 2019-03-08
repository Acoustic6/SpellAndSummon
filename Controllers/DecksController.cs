using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpellAndSummon.Models;

namespace SpellAndSummon.Controllers {
    [Route("/api/decks")]
    public class DecksController : Controller
    {
        [HttpPost]
        public IActionResult CreateDeck([FromBody]Deck deck)
        {
            return Ok(deck);
        }
    }
}