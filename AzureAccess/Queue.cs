using System.Configuration;
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
    }
}