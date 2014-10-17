using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureAccess;

namespace App.HashtagInfo.Controllers
{
    public class RecentTagQueueController : ApiController
    {
        private readonly IQueue _queue;

        public RecentTagQueueController()
            : this(new Queue()) { }

        public RecentTagQueueController(IQueue queue)
        {
            _queue = queue;
        }

        // GET: RecentTagQueue
        public IEnumerable<string> Get()
        {
            return _queue.PeekAll();
        }
        // PUT: RecentTagQueue/5
        public void Put(string id)
        {
            _queue.AddToQueue(id);
        }
    }
}
