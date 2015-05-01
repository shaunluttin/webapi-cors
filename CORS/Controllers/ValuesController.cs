using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CORS.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "This is a CORS request.", "That works from any origin." };
        }

        // GET api/values/another
        [HttpGet]
        [EnableCors(origins:"http://www.bigfont.ca", headers:"*", methods: "*")]
        public IEnumerable<string> Another()
        {
            return new string[] { "This is a CORS request.", "It works only from www.bigfont.ca." };
        }
        
        public class EstimateQuery
        {
            public string username { get; set; }
        }
        
        public IHttpActionResult GetTitleEstimate([FromUri] EstimateQuery query)
        {
            // All the values in "query" are null or zero
            // Do some stuff with query if there were anything to do
            
            return Ok();
        }        
    }
}
