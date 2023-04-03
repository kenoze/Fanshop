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
    public class proizvod : ControllerBase
    {
        Fan_shopContext db = new Fan_shopContext();
        // GET: api/<proizvod>
        [HttpGet]
        public IActionResult prikazi_sve_proizvode() //za select svega 

        {

            List<Proizvod> podaci = db.Proizvod.OrderByDescending(r => r.ProductName).ToList();

            return Ok(podaci);

        }
        [HttpGet]
        public IActionResult sortiraj() //za select svega 

        {

            List<Proizvod> podacc = db.Proizvod.OrderByDescending(r => r.ListPrice).ToList();

            return Ok(podacc);

        }
        [HttpGet]

        public IActionResult prikazi_filter_proizvoda(string parametar) //za select po filteru 

        {

            List<Proizvod> rezultat = db.Proizvod.Where(r => r.ProductName.Contains(parametar)).ToList();

            //select * from  where.... 

            return Ok(rezultat);

        }

        // GET api/<proizvod>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<proizvod>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<proizvod>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<proizvod>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Proizvod podaci = db.Proizvod.Where(r => r.ProductId == id).FirstOrDefault();
            if (podaci == null)
            {
                return NotFound("Nije pronadjen proizvod sa tim ID-jem");
            }
            else
            {
                db.Remove(podaci);
                db.SaveChanges();
                //cascade delete cascade update

            }
            return Ok("Obrisano");
        }
        [HttpPost]
        public IActionResult Objavi([FromBody] Proizvod proizvod)
        {
            db.Add(proizvod);
            db.SaveChanges();
            return Ok(proizvod.ProductId);
        }
        [HttpGet]
        public IActionResult Azuriraj(int parametar, string novoime)
        {
            var podaci = db.Proizvod.Where(r => r.ProductId == parametar).FirstOrDefault();
            if (podaci == null)
            {
                return NotFound("Nije pronadjen polaznik sa tim ID-jem");
            }
            else
            {
                podaci.ProductName = novoime;
                db.SaveChanges();
                return Ok("Azurirano");
            }


          
        }
    }
}
