using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace DeckOfCardsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        //make a method that can handle an HttpGet call
        [HttpGet]
        [Route("[action]")]
        public async Task<string> GetDeck()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient
                    .GetAsync("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1"))
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }   

        [HttpGet]
        [Route("[action]")]
        public int GetInt()
        {
            return 42;
        }
    }
}