using Microsoft.AspNetCore.Mvc;
using RPG_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character {Name = "Sam"}
        };

        [Route("GetAll")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [Route("GetSingle")]
        [HttpGet]
        public IActionResult GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}