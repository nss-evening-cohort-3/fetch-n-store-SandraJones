using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fetch_and_Store.Controllers
{
    public class ResponseController : ApiController
    {
        // GET api/<controller> will get object including status code etc. plus html page
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5DA this is to pull one row based upon ID from table in DB
        public string Get(string address)
        {
            return address;
        }

        // POST api/<controller>
        public IEnumerable<string> Post([FromBody] dynamic data)
        {
            return new string[] { data.Class.Value, data.name.Value };//case must match controller case
        }

        public void Post([FromBody]string value)//cannot add to this like json data
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}