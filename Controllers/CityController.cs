using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        public CityController()
        {
                
        }

        [HttpGet]
        public IEnumerable<string> Getstrings()
        {
            return new string[] { "Atalanta", "New york", "Dettroit","Masachusets"};
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return  "Atalanta";
        }


    }
}
