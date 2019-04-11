using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BilletLibrary;
using System.Xml;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Newtonsoft.Json;

namespace BilletSystem_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ØresundController : ControllerBase
    {
        Bil bil = new Bil();
        private BilDTO bilDto = new BilDTO();

        

        // GET: api/Øresund
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

        // GET: api/Øresund/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Øresund
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Øresund/5
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
