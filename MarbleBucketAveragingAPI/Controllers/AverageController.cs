using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MarbleBucketAveragingAPI.Controllers
{
    public class AverageController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostValues([FromBody] double[] values)
        {
            if(values == null)
            {
                return BadRequest();
            }

            Console.Write("Received the following values: {0}. ", String.Join(", ", values));

            double result = values.Average();

            Console.WriteLine("Returning the following result: {0}.", result);

            return Ok(result);

        }

    }
}
