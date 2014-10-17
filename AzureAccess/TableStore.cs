using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace AzureAccess
{
    public class TableStore : ITableStore
    {
        private readonly CloudTable _table;

        public TableStore()
        {
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            var tableClient = storageAccount.CreateCloudTableClient();
            _table = tableClient.GetTableReference(TableName);
        }

        public IList<Hashtag> Get(string sourceHashtag)
        {
            var query = new TableQuery<HashtagEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, sourceHashtag));

            // Print the fields for each customer.
            //foreach (var hashtagEntity in _table.ExecuteQuery(query))
            //{
            //    Console.WriteLine("{0}, {1}\t{2}\t{3}", hashtagEntity.PartitionKey, hashtagEntity.RowKey, hashtagEntity.HashtagName);
            //}

            return _table.ExecuteQuery(query).Select(h=>new Hashtag{ Name = h.HashtagName }).ToList();
        }

        public const string TableName = "RelatedTags";
    }
}