using AutoMapper;
using AutoMapper.Models;
using AutoMapperExample.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoMapperExample.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClientRepositories _repositories;

        public HomeController(IMapper mapper, IClientRepositories repositories)
        {
            _mapper = mapper;
            _repositories = repositories;
        }

        [HttpPost("Create")]
        public ActionResult<Client> Create([FromBody] Person person)
        {
            Client client = _mapper.Map<Client>(person);

            return StatusCode(201, client);
        }

        [HttpGet("List")]
        public ActionResult<Person> List()
        {
            List<Person> list = _mapper.Map<List<Person>>(_repositories.GetAll());

            return Ok(list);
        }
    }
}
