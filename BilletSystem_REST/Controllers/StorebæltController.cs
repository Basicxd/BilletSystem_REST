using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilletLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilletSystem_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorebæltController : ControllerBase
    {
        Bil bil = new Bil();
        private BilDTO bilDto = new BilDTO();

        // GET: api/Storebælt
        [HttpGet]
        public BilDTO Get()
        {
            //bilDto.pris = bil.Pris();
            //bilDto.type = bil.KøreTøjType();

            //bil.BroBizz = true;
            //bil.Pris();
            //bil.KøreTøjType();
            //bil.NummerPlade = "BS69699";
            //bil.Dato = DateTime.Now;

            return bilDto;
        }

        // GET: api/Storebælt/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Storebælt
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Storebælt/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
