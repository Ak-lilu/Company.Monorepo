using BackendCodes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendCodes.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AdventureWorksLT2019Context _db;
        public AddressController(AdventureWorksLT2019Context db)
        {
            _db = db;
        }
        // GET: api/<AddressController>
        [HttpGet]
        public List<Address> Get()
        {
            var _addresses = _db.Addresses.ToList();
            return _addresses;
        }
        [HttpGet("Specifics")]
        public List<Address> GetAddresses()
        {
            var list = _db.Addresses.Where(x => x.CountryRegion == "").ToList();
            return list;
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
