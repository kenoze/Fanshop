using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class kupac : ControllerBase
    {
        Fan_shopContext db = new Fan_shopContext();
        // GET: api/<kupac>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<kupac>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<kupac>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<kupac>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<kupac>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet]
        public IActionResult prikazi_kupce() //za select svega 

        {

            List<Kupac> podaci = db.Kupac.OrderByDescending(r => r.FirstName).ToList();

            return Ok(podaci);

        }
    }
}
