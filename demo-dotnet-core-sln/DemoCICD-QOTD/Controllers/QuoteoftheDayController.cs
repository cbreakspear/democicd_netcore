using Microsoft.AspNetCore.Mvc;

namespace DemoCICD_QOTD.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class QuoteoftheDayController : ControllerBase
    {
        private static readonly string[] Quotes = new[]
        {
        "It's not easy being Cheezy",
        "Hard choices, easy life. Easy choices, hard life. Jerzy Gregory",
        "Men must live and create. Live to the point of tears. Albert Camus",
        "Somewhere, something incredible is waiting to be known. Sharon Begley",
        "Memories of our lives, of our works and our deeds will continue in others. Rosa Parks"
    };


        [HttpGet(Name = "getQuoteoftheDay")]
        public IEnumerable<string> Get()
        {
            return new string[] { "quote", Quotes[Random.Shared.Next(Quotes.Length)] };
        }
    }
}