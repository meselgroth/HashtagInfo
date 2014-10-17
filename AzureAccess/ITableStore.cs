using System.Collections.Generic;

namespace AzureAccess
{
    public interface ITableStore
    {
        IList<Hashtag> Get(string sourceHashtag);
    }
}