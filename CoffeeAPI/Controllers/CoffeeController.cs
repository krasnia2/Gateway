using System;
using System.Net;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new string[] 
        {
            "Flat White", "Long Black", "Latte", "Americano", "Cappuccino"
        };

        [HttpGet]
        public ActionResult GetAction()
        {
            var random = new Random();

            return Ok(Coffees[random.Next(Coffees.Length)]);
        }
    }
}