using System.Collections.Generic;
using System.Web.Http;

namespace CORS.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "This is a CORS request.", "That works from any origin." };
        }
    }
}