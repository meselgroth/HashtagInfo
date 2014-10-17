using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureAccess;

namespace App.HashtagInfo.Controllers
{
    public class HashtagInfoController : ApiController
    {
        private readonly ITableStore _tableStore;

        public HashtagInfoController()
            : this(new TableStore()) { }

        public HashtagInfoController(ITableStore tableStore)
        {
            _tableStore = tableStore;
        }
        // GET: api/HashtagInfo/5
        public IList<Hashtag> Get(string id)
        {
            return _tableStore.Get(id);
        }

        // POST: api/HashtagInfo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HashtagInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HashtagInfo/5
        public void Delete(int id)
        {
        }
    }
}
