using Azure.Pipeline.API.Models;

namespace Azure.Pipeline.API.Repositories
{
    public interface IDocumentRepository
    {
        IEnumerable<Document> GetDocuments();
    }
}
