using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace AzureAccess
{
    public class Queue : IQueue
    {
        private readonly CloudQueue _cloudQueue;

        public Queue()
        {
            var storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);

            var queueClient = storageAccount.CreateCloudQueueClient(); 

            _cloudQueue = queueClient.GetQueueReference("recenttagqueue");
            _cloudQueue.CreateIfNotExists();
        }

        public void AddToQueue(string hashtag)
        {
            _cloudQueue.AddMessage(new CloudQueueMessage(hashtag));
        }

        public IEnumerable<string> PeekAll()
        {
            return _cloudQueue.PeekMessages(20).Select(m=>m.AsString);
        }
    }
}