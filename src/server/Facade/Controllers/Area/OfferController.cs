using System.Collections.Generic;
using System.Web.Http;

namespace Todom.Facade.Controllers.Area
{
    public partial class OfferController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        public void Post([FromBody] string value) { }

        public void Put(int id, [FromBody] string value) { }

        public void Delete(int id) { }
    }
}