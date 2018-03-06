using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        /// <summary>
        /// Some test
        /// </summary>
        /// <param name="model">the model that make a problem</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<string>), 200)]
        public IEnumerable<string> Get([FromQuery] Request1 model)
        {
            return new string[] { "value1", "value2" };
        }

       
    }
}
