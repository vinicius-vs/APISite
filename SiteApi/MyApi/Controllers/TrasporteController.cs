using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repository;
using Data.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrasporteController : ControllerBase
    {

        TrasporteRepository repository = new TrasporteRepository();

        // GET: api/<TrasporteController>
        [HttpGet]
        public List<TrasporteModel> Get()
        {
            return repository.Read();
        }

        // GET api/<TrasporteController>/5
        [HttpGet("{id}")]
        public TrasporteModel Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<TrasporteController>
        [HttpPost]
        public void Post([FromBody] TrasporteModel value)
        {
            repository.Create(value);
        }

        // PUT api/<TrasporteController>/5
        [HttpPut]
        public void Put([FromBody] TrasporteModel value)
        {
            repository.Update(value);
        }

        // DELETE api/<TrasporteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
