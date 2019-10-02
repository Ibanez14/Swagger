using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.Learning.Controllers
{


    /// <summary>
    /// Values Controller related comment
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json", "Whatever/json")]
    public class ValuesController : ControllerBase
    {


        /// <summary>
        /// Simple http get method to check commemt generation
        /// </summary>
        /// <remarks>
        /// Rolling on the river
        /// 
        /// </remarks>
        /// 
        /// <returns></returns>
        /// 
        /// <response code="200">Response newly created model</response>
        [ProducesResponseType(200)]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public void Post([FromBody] StringBuilder value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{model}")]
        public void Delete(PersonModel model)
        {
        }
    }
}
