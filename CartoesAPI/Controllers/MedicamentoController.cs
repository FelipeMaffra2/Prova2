using CartoesAPI.Data;
using CartoesAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartoesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        private CardContext _context;

        public CardController(CardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards;
        }
        [HttpPost]
        public IActionResult AddCard([FromBody] Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardById), new { Id =  card.Id}, card);
        }
        /* Exemplo JSON
          {
            "Id":2,
            "Number":"1111222233335555",
            "ExpiredDate":"2025-10-21",
            "Cvv":"123"
          }
        */

        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            Card card = _context.Cards.FirstOrDefault(card => card.Id == id);
            if(card != null)
            {
                return Ok(card);
            }
            return NotFound();
        }

    }
}
