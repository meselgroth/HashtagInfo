using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureAccess;

namespace App.HashtagInfo.Controllers
{
    public class HashtagController : ApiController
    {
        private readonly IQueue _queue;

        public HashtagController()
            : this(new Queue())
        {

        }

        public HashtagController(IQueue queue)
        {
            _queue = queue;
        }

        // GET: api/Hashtag
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hashtag/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hashtag
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hashtag/5
        public void Put([FromBody]string value)
        {
            _queue.AddToQueue(value);
        }

        // DELETE: api/Hashtag/5
        public void Delete(int id)
        {
        }
    }
}
