using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webApiEF.Models;

namespace webApiEF.Controllers {

    [Route("api/[controller]")]
    public class AtorController : Controller {

        private SakilaDbContext dbContext;

        public AtorController() {
            string connectionString = "server=localhost;port=3306;database=sakila_tiagopassos;userid=root;pwd=;sslmode=none";
            dbContext = SakilaDbContextFactory.Create(connectionString);
        }

        // GET api/ator
        [HttpGet]
        public ActionResult Get() {
            return Ok(dbContext.Ator.ToArray());
        }

        // GET api/ator/101
        [HttpGet("{id}")]
        public ActionResult Get(int id) {
            
            var atorParm = dbContext.Ator.SingleOrDefault(a => a.ID == id);
            
            if (atorParm != null) {
                return Ok(atorParm);
            } else {
                return NotFound();
            }
        }

        // POST api/atores
        [HttpPost]
        public ActionResult Post([FromBody]Ator atorParm) {
            
            if (!ModelState.IsValid)
                return BadRequest();

            dbContext.Ator.Add(atorParm);
            
            dbContext.SaveChanges();
            
            return Created("api/ator", atorParm);
        }

        // PUT api/actors/101
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Ator atorParm) {
            
            var target = dbContext.Ator.SingleOrDefault(a => a.ID == id);

            if (target != null && ModelState.IsValid) {
                dbContext.Entry(target).CurrentValues.SetValues(atorParm);
                dbContext.SaveChanges();
                
                return Ok();
            } 
            else {
                return BadRequest();
            }
        }

        // DELETE api/actors/101
        [HttpDelete("{id}")]
        public ActionResult Delete(int id) {
            var atorParm = dbContext.Ator.SingleOrDefault(a => a.ID == id);
            if (atorParm != null) {
                dbContext.Ator.Remove(atorParm);
                dbContext.SaveChanges();
                
                return Ok();
            } 
            else {
                return NotFound();
            }
        }
    }
}