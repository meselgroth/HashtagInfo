using System.Collections;
using System.Collections.Generic;

namespace AzureAccess
{
    public interface IQueue
    {
        void AddToQueue(string hashtag);
        IEnumerable<string> PeekAll();
    }
}