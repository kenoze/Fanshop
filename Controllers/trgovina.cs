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
    public class trgovina : ControllerBase
    {
        Fan_shopContext db = new Fan_shopContext();
        // GET: api/<trgovina>

        [HttpGet]
        public IActionResult prikazi_trgovine() //za select svega 

        {

            List<Trgovina> podaci = db.Trgovina.OrderByDescending(r => r.StoreName).ToList();

            return Ok(podaci);

        }
        // GET api/<trgovina>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<trgovina>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<trgovina>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<trgovina>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
