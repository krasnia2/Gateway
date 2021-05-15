using System;
using System.Net;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new string[] 
        {
            "Gren", "Perppermint", "Eearl Gray", "English Breakfast", "Camomile"
        };

        [HttpGet]
        public ActionResult GetAction()
        {
            var random = new Random();

            return Ok(Teas[random.Next(Teas.Length)]);
        }
    }
}