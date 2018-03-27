using System.Security;
using Examine.LuceneEngine.Providers;
using Lucene.Net.Store;

namespace Examine.LuceneEngine.Directories
{
    public interface IDirectoryFactory
    {
        
        Directory CreateDirectory(LuceneIndexer indexer, string luceneIndexFolder);
    }
}