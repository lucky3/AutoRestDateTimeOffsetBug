using System;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApi1.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [Route(nameof(PostRawDate))]
        public IHttpActionResult PostRawDate(DateTimeOffset dateTimeOffset)
        {
            return Ok(dateTimeOffset);
        }

        [Route(nameof(PostWrappedRawDate))]
        public IHttpActionResult PostWrappedRawDate(OffsetWrapper wrapper)
        {
            return Ok(wrapper.Offset);
        }

        public class OffsetWrapper
        {
            public DateTimeOffset Offset { get; set; }
        }
    }
}
