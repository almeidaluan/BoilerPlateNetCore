﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateNetCore.gateway;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPersonRepository personRepository;
        public ValuesController(IPersonRepository personRepository){
            this.personRepository = personRepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(personRepository.listPerson());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
