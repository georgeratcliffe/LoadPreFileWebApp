using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoadPreFileWebApp.DTOS;
using LoadPreFileWebApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoadPreFileWebApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private ILoadFile _loadfileservice;

        public FilesController(ILoadFile loadfileservice)
        {
            _loadfileservice = loadfileservice;
        }
        // GET: api/<FilesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/<FilesController>
        [HttpPost]
        public IActionResult Post([FromBody] FileNameDTO filename)
        {
            return Ok(_loadfileservice.LoadFile(filename));
        }

      
    }
}
